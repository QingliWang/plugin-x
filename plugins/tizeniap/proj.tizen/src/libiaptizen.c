/*
 * Copyright (c) 2014 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


/**
 * This file contains the exported symbol.
 */
#include "libiaptizen.h"


#include <app_control.h>

static void
_get_country_list_cb(app_control_h request, app_control_h reply, app_control_result_e result, void *user_data);

static void
_get_item_list_cb(app_control_h request, app_control_h reply, app_control_result_e result, void *user_data);

static void
_get_purchased_item_list_cb(app_control_h request, app_control_h reply, app_control_result_e result, void *user_data);

static void
_get_purchase_cb(app_control_h request, app_control_h reply, app_control_result_e result, void *user_data);

static void
_get_country_list_operation_call(request_param_s *param);

static void
_get_item_list_operation_call(request_param_s *param);

static void
_get_purchased_item_list_operation_call(request_param_s *param);

static void
_purchase_operation_call(request_param_s *param);

static void
_get_char_extra_data(app_control_h app_control, char *target, char *param_name, int num);

static void
_get_int_extra_data(app_control_h app_control, int *target, char *param_name, int num);


void
_get_country_list_cb(app_control_h request, app_control_h reply, app_control_result_e result, void *user_data){
	_INFO("get_country_list result callback start!");
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);

	request_param_s *param = (request_param_s *)user_data;
	if (!param){
		return;
	}

	param->result.req_type = FUNC_GET_COUNTRY_LIST;
	param->result.err_type = ERROR_ALL_SUCCESS;

	_INFO("INFOOOOO  ****  param = %x", param);
	_INFO("INFOOOOO  ****  callback_fn = %x", param->callback_fn);
	_INFO("INFOOOOO  ****  transaction id = %d", param->transaction_id);
	_INFO("INFOOOOO  ****  req = %d", param->result.req_type);
	_INFO("INFOOOOO  ****  err = %d", param->result.err_type);
	_INFO("INFOOOOO  ****  country list = %x", param->result.country_list_result);

	country_list_s *list = param->result.country_list_result;

	if (!list){
		param->result.err_type = ERROR_ALLOC_FAIL;
		goto error_label;
	}

	if (result == APP_CONTROL_RESULT_SUCCEEDED){
		list->item_size = 0;

		_get_char_extra_data(reply, list->method, PARAM_RESPONSE_METHOD, -1);

		_get_char_extra_data(reply, list->result, PARAM_RESPONSE_RESULT, -1);
		_get_char_extra_data(reply, list->transaction_id, PARAM_RESPONSE_TRANSACTION_ID, -1);
		if (!strcmp(RESULT_SUCCESS, list->result)){
			_get_char_extra_data(reply, list->result_description, PARAM_RESPONSE_RESULT_DESCRIPTION, -1);
			_get_int_extra_data(reply, &(list->start_number), PARAM_RESPONSE_START_NUMBER, -1);
			_get_int_extra_data(reply, &(list->end_number), PARAM_RESPONSE_END_NUMBER, -1);
			_get_int_extra_data(reply, &(list->total_count), PARAM_RESPONSE_TOTAL_COUNT, -1);
			if (list->start_number > 0 && list->end_number > 0){
				int index_start, j=0;
				for(index_start = list->start_number; index_start <= list->end_number; index_start++){
					_get_char_extra_data(reply, list->items[j]->name, PARAM_RESPONSE_COUNTRY_NAME, index_start);
					_get_char_extra_data(reply, list->items[j]->mcc, PARAM_RESPONSE_MCC, index_start);
					j++;
				}
				list->item_size = j;
			}
		} else {
			param->result.err_type = ERROR_RESULT_FAIL;
			goto error_label;
		}
	} else {
		if (result == APP_CONTROL_RESULT_FAILED || result == APP_CONTROL_RESULT_CANCELED){
			param->result.err_type = ERROR_RESULT_FAIL;
		} else {
			param->result.err_type = ERROR_UNKNOWN_ERROR;
		}
		goto error_label;
	}


	param->callback_fn(param->result);
	if(param){
		free(param);
		param = NULL;
	}

	return;

error_label:
	_ERR("ERROR : err = %d ", param->result.err_type);
	param->callback_fn(param->result);
	if(param){
		free(param);
		param = NULL;
	}

    return;
}

void
_get_item_list_cb(app_control_h request, app_control_h reply, app_control_result_e result, void *user_data){

	_INFO("get_item_list result callback start!");
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);

	request_param_s *param = (request_param_s *)user_data;
	if (!param){
		return;
	}

	param->result.req_type = FUNC_GET_ITEM_LIST;
	param->result.err_type = ERROR_ALL_SUCCESS;

	item_list_s *list;
	list = param->result.item_list_result;
	if (!list){
		param->result.err_type = ERROR_ALLOC_FAIL;
		goto error_label;
	}

	if (result == APP_CONTROL_RESULT_SUCCEEDED){
		list->item_size = 0;
		_get_char_extra_data(reply, list->method, PARAM_RESPONSE_METHOD, -1);
		_get_char_extra_data(reply, list->result, PARAM_RESPONSE_RESULT, -1);
		_get_char_extra_data(reply, list->transaction_id, PARAM_RESPONSE_TRANSACTION_ID, -1);
		if (!strcmp(RESULT_SUCCESS, list->result)){

			_get_char_extra_data(reply, list->result_description, PARAM_RESPONSE_RESULT_DESCRIPTION, -1);

			_get_int_extra_data(reply, &(list->start_number), PARAM_RESPONSE_START_NUMBER, -1);
			_get_int_extra_data(reply, &(list->end_number), PARAM_RESPONSE_END_NUMBER, -1);
			_get_int_extra_data(reply, &(list->total_count), PARAM_RESPONSE_TOTAL_COUNT, -1);
			_get_int_extra_data(reply, &(list->item_total_count), PARAM_RESPONSE_ITEM_TOTAL_COUNT, -1);

			if (list->total_count > 0 && list->start_number > 0 && list->end_number > 0){
				int index_start, j=0;
				for(index_start = list->start_number; index_start <= list->end_number; index_start++){
						_get_char_extra_data(reply,  list->items[j]->item_id, PARAM_RESPONSE_ITEM_ID, index_start);
						_get_char_extra_data(reply,  list->items[j]->item_group_id, PARAM_RESPONSE_ITEM_GROUP_ID, index_start);
						_get_char_extra_data(reply,  list->items[j]->item_name, PARAM_RESPONSE_ITEM_NAME, index_start);
						_get_char_extra_data(reply,  list->items[j]->currency_unit, PARAM_RESPONSE_CURRENCY_UNIT, index_start);
						_get_char_extra_data(reply,  list->items[j]->unit_precedes, PARAM_RESPONSE_UNIT_PRECEDES, index_start);
						_get_char_extra_data(reply,  list->items[j]->has_penny, PARAM_RESPONSE_HAS_PENNY, index_start);
						_get_char_extra_data(reply,  list->items[j]->item_price, PARAM_RESPONSE_ITEM_PRICE, index_start);
						_get_char_extra_data(reply,  list->items[j]->item_download_url, PARAM_RESPONSE_ITEM_DOWNLOAD_URL, index_start);
						_get_char_extra_data(reply,  list->items[j]->item_image_url, PARAM_RESPONSE_ITEM_IMAGE_URL, index_start);
						_get_char_extra_data(reply,  list->items[j]->item_description, PARAM_RESPONSE_ITEM_DESCRIPTION, index_start);
						_get_char_extra_data(reply,  list->items[j]->reserved1, PARAM_RESPONSE_RESERVED1, index_start);
						_get_char_extra_data(reply,  list->items[j]->reserved2, PARAM_RESPONSE_RESERVED2, index_start);
						_get_char_extra_data(reply,  list->items[j]->item_type_cd, PARAM_RESPONSE_ITEM_TYPE_CD, index_start);
						_get_char_extra_data(reply,  list->items[j]->item_subs_bill_duration_cd, PARAM_RESPONSE_ITEM_SUBS_BILL_DURATION_CD, index_start);
						_get_char_extra_data(reply,  list->items[j]->subscription_duration_multiplier, PARAM_RESPONSE_SUBSCRIPTION_DURATION_MULTIPLIER, index_start);
						_get_char_extra_data(reply,  list->items[j]->time_stamp, PARAM_RESPONSE_TIME_STAMP, index_start);
					j++;
				}
				list->item_size = j;
			}
		} else {
			param->result.err_type = ERROR_RESULT_FAIL;
			goto error_label;
		}
	} else {
		if (result == APP_CONTROL_RESULT_FAILED){
			param->result.err_type = ERROR_RESULT_FAIL;
		} else if (result == APP_CONTROL_RESULT_CANCELED) {
			param->result.err_type = ERROR_RESULT_CANCELLED;
		} else {
			param->result.err_type = ERROR_UNKNOWN_ERROR;
		}
		goto error_label;
	}


	param->callback_fn(param->result);
	if(param){
		free(param);
		param = NULL;
	}
	return;

error_label:
	_ERR("ERROR : err = %d ", param->result.err_type);
	param->callback_fn(param->result);
	if(param){
		free(param);
		param = NULL;
	}
	return;
}


void
_get_purchased_item_list_cb(app_control_h request, app_control_h reply, app_control_result_e result, void *user_data){
	_INFO("get_purchased_item_list result callback start!");
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);

	request_param_s *param = (request_param_s *)user_data;
	if (!param){
		return;
	}

	param->result.req_type = FUNC_GET_PURCHASED_ITEM_LIST;
	param->result.err_type = ERROR_ALL_SUCCESS;

	item_list_s *list = param->result.item_list_result;

	if (!list){
		param->result.err_type = ERROR_ALLOC_FAIL;
		goto error_label;
	}

	if (result == APP_CONTROL_RESULT_SUCCEEDED){
		list->item_size = 0;
		_get_char_extra_data(reply, list->method, PARAM_RESPONSE_METHOD, -1);
		_get_char_extra_data(reply, list->result, PARAM_RESPONSE_RESULT, -1);
		_get_char_extra_data(reply, list->transaction_id, PARAM_RESPONSE_TRANSACTION_ID, -1);
		if (!strcmp(RESULT_SUCCESS, list->result)){
			_get_char_extra_data(reply, list->result_description, PARAM_RESPONSE_RESULT_DESCRIPTION, -1);

			_get_int_extra_data(reply, &(list->start_number), PARAM_RESPONSE_START_NUMBER, -1);
			_get_int_extra_data(reply, &(list->end_number), PARAM_RESPONSE_END_NUMBER, -1);
			_get_int_extra_data(reply, &(list->total_count), PARAM_RESPONSE_TOTAL_COUNT, -1);
			_get_int_extra_data(reply, &(list->item_total_count), PARAM_RESPONSE_ITEM_TOTAL_COUNT, -1);

			if (list->total_count > 0 && list->start_number > 0 && list->end_number > 0){
				int index_start, j=0;
				for(index_start = list->start_number; index_start <= list->end_number; index_start++){
					_get_char_extra_data(reply,  list->items[j]->item_id, PARAM_RESPONSE_ITEM_ID, index_start);
					_get_char_extra_data(reply,  list->items[j]->item_group_id, PARAM_RESPONSE_ITEM_GROUP_ID, index_start);
					_get_char_extra_data(reply,  list->items[j]->item_name, PARAM_RESPONSE_ITEM_NAME, index_start);
					_get_char_extra_data(reply,  list->items[j]->currency_unit, PARAM_RESPONSE_CURRENCY_UNIT, index_start);
					_get_char_extra_data(reply,  list->items[j]->unit_precedes, PARAM_RESPONSE_UNIT_PRECEDES, index_start);
					_get_char_extra_data(reply,  list->items[j]->has_penny, PARAM_RESPONSE_HAS_PENNY, index_start);
					_get_char_extra_data(reply,  list->items[j]->item_price, PARAM_RESPONSE_ITEM_PRICE, index_start);
					_get_char_extra_data(reply,  list->items[j]->item_download_url, PARAM_RESPONSE_ITEM_DOWNLOAD_URL, index_start);
					_get_char_extra_data(reply,  list->items[j]->item_image_url, PARAM_RESPONSE_ITEM_IMAGE_URL, index_start);
					_get_char_extra_data(reply,  list->items[j]->item_description, PARAM_RESPONSE_ITEM_DESCRIPTION, index_start);
					_get_char_extra_data(reply,  list->items[j]->reserved1, PARAM_RESPONSE_RESERVED1, index_start);
					_get_char_extra_data(reply,  list->items[j]->reserved2, PARAM_RESPONSE_RESERVED2, index_start);
					_get_char_extra_data(reply,  list->items[j]->payment_id, PARAM_RESPONSE_PAYMENT_ID, index_start);
					_get_char_extra_data(reply,  list->items[j]->purchase_date, PARAM_RESPONSE_PURCHASE_DATE, index_start);
					_get_char_extra_data(reply,  list->items[j]->item_type_cd, PARAM_RESPONSE_ITEM_TYPE_CD, index_start);
					_get_char_extra_data(reply,  list->items[j]->item_subs_bill_duration_cd, PARAM_RESPONSE_ITEM_SUBS_BILL_DURATION_CD, index_start);
					_get_char_extra_data(reply,  list->items[j]->subscription_duration_multiplier, PARAM_RESPONSE_SUBSCRIPTION_DURATION_MULTIPLIER, index_start);
					_get_char_extra_data(reply,  list->items[j]->time_stamp, PARAM_RESPONSE_TIME_STAMP, index_start);

					j++;
				}
				list->item_size = j;
			}
		} else {
			param->result.err_type = ERROR_RESULT_FAIL;
			goto error_label;
		}
	} else {
		if (result == APP_CONTROL_RESULT_FAILED){
			param->result.err_type = ERROR_RESULT_FAIL;
		} else if (result == APP_CONTROL_RESULT_CANCELED) {
			param->result.err_type = ERROR_RESULT_CANCELLED;
		} else {
			param->result.err_type = ERROR_UNKNOWN_ERROR;
		}
		goto error_label;
	}



	param->callback_fn(param->result);
	if(param){
		free(param);
		param = NULL;
	}
	return;

error_label:
	_ERR("ERROR :  err = %d ", param->result.err_type);
	param->callback_fn(param->result);
	if(param){
		free(param);
		param = NULL;
	}
	return;
}

void
_get_purchase_cb(app_control_h request, app_control_h reply, app_control_result_e result, void *user_data){
	_INFO("purchase result callback start!");
	_INFO("purchase result callback result:%d", result);
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);

	request_param_s *param = (request_param_s *)user_data;
	if (!param){
		return;
	}

	param->result.req_type = FUNC_PURCHASE;
	param->result.err_type = ERROR_ALL_SUCCESS;

	purchase_s *purchase = param->result.purchase_result;

	if (result == APP_CONTROL_RESULT_SUCCEEDED){
		_get_char_extra_data(reply, purchase->method, PARAM_RESPONSE_METHOD, -1);
		_get_char_extra_data(reply, purchase->result, PARAM_RESPONSE_RESULT, -1);
		_get_char_extra_data(reply, purchase->transaction_id, PARAM_RESPONSE_TRANSACTION_ID, -1);
		if(!strcmp(purchase->transaction_id,"0"))
			sprintf(purchase->transaction_id, "%d", param->transaction_id);
		if (!strcmp(RESULT_SUCCESS, purchase->result)){
			_get_char_extra_data(reply, purchase->result_description, PARAM_RESPONSE_RESULT_DESCRIPTION, -1);
			_get_char_extra_data(reply, purchase->item_id, PARAM_RESPONSE_ITEM_ID, -1);
			_get_char_extra_data(reply, purchase->item_group_id, PARAM_RESPONSE_ITEM_GROUP_ID, -1);
			_get_char_extra_data(reply, purchase->item_name, PARAM_RESPONSE_ITEM_NAME, -1);
			_get_char_extra_data(reply, purchase->ticket_purchase_id, PARAM_RESPONSE_TICKET_PURCHASE_ID, -1);
			_get_char_extra_data(reply, purchase->currency_unit, PARAM_RESPONSE_CURRENCY_UNIT, -1);
			_get_char_extra_data(reply, purchase->unit_precedes, PARAM_RESPONSE_UNIT_PRECEDES, -1);
			_get_char_extra_data(reply, purchase->has_penny, PARAM_RESPONSE_HAS_PENNY, -1);
			_get_char_extra_data(reply, purchase->item_price, PARAM_RESPONSE_ITEM_PRICE, -1);
			_get_char_extra_data(reply, purchase->item_download_url, PARAM_RESPONSE_ITEM_DOWNLOAD_URL, -1);
			_get_char_extra_data(reply, purchase->item_image_url, PARAM_RESPONSE_ITEM_IMAGE_URL, -1);
			_get_char_extra_data(reply, purchase->item_description, PARAM_RESPONSE_ITEM_DESCRIPTION, -1);
			_get_char_extra_data(reply, purchase->reserved1, PARAM_RESPONSE_RESERVED1, -1);
			_get_char_extra_data(reply, purchase->reserved2, PARAM_RESPONSE_RESERVED2, -1);
			_get_char_extra_data(reply, purchase->payment_id, PARAM_RESPONSE_PAYMENT_ID, -1);
			_get_char_extra_data(reply, purchase->ticket_verify_url, PARAM_RESPONSE_TICKET_VERIFY_URL, -1);
			_get_char_extra_data(reply, purchase->ticket_purchase_id, PARAM_RESPONSE_TICKET_PURCHASE_ID, -1);
			_get_char_extra_data(reply, purchase->ticket_param1, PARAM_RESPONSE_TICKET_PARAM_1, -1);
			_get_char_extra_data(reply, purchase->ticket_param2, PARAM_RESPONSE_TICKET_PARAM_2, -1);
			_get_char_extra_data(reply, purchase->ticket_param3, PARAM_RESPONSE_TICKET_PARAM_3, -1);
			_get_char_extra_data(reply, purchase->ticket_param4, PARAM_RESPONSE_TICKET_PARAM_4, -1);
			_get_char_extra_data(reply, purchase->ticket_param5, PARAM_RESPONSE_TICKET_PARAM_5, -1);
			_get_char_extra_data(reply, purchase->purchase_date, PARAM_RESPONSE_PURCHASE_DATE, -1);
			_get_char_extra_data(reply, purchase->item_type_cd, PARAM_RESPONSE_ITEM_TYPE_CD, -1);
			_get_char_extra_data(reply, purchase->item_subs_bill_duration_cd, PARAM_RESPONSE_ITEM_SUBS_BILL_DURATION_CD, -1);
			_get_char_extra_data(reply, purchase->sub_scription_duration_multiplier, PARAM_RESPONSE_SUBSCRIPTION_DURATION_MULTIPLIER, -1);
			_get_char_extra_data(reply, purchase->time_stamp, PARAM_RESPONSE_TIME_STAMP, -1);
		} else {
			param->result.err_type = ERROR_RESULT_FAIL;
			goto error_label;
		}
	} else {
		if (result == APP_CONTROL_RESULT_FAILED){
			param->result.err_type = ERROR_RESULT_FAIL;
		} else if (result == APP_CONTROL_RESULT_CANCELED) {
			param->result.err_type = ERROR_RESULT_CANCELLED;
		} else {
			param->result.err_type = ERROR_UNKNOWN_ERROR;
		}
		goto error_label;
	}

	param->callback_fn(param->result);
	if(param){
		free(param);
		param = NULL;
	}
	return;

error_label:
	_ERR("ERROR :  err = %d ", param->result.err_type);
	param->callback_fn(param->result);
	_INFO("INFO : YAY !!!!  Callback Complete !!! ");
	if(param){
		free(param);
		param = NULL;
	}
	_INFO("INFO : YAY !!!!  Callback Complete !!! ");
	return;
}

void
_get_country_list_operation_call(request_param_s *param){
	app_control_h app_control;
	iap_error_e err = ERROR_ALL_SUCCESS;
	request_param_s *requestParam = (request_param_s *)calloc(1, sizeof(request_param_s));

	int rt = app_control_create(&app_control);

	if (rt == APP_CONTROL_ERROR_NONE){
		if (param){
			char buffer[1024] = {0,};
			snprintf(buffer, sizeof(buffer), "%d", param->transaction_id);

			app_control_set_app_id(app_control, IAP_SERVICE_APP_ID);

			app_control_set_operation(app_control, OPERATION_GET_COUNTRY_LIST);

			app_control_add_extra_data(app_control, PARAM_REQUEST_MODE, "0");
			app_control_add_extra_data(app_control, PARAM_REQUEST_TRANSACTION_ID, buffer);


			memcpy(requestParam, param, sizeof(request_param_s));			
			_INFO("INFOOOOO  ****  callback_fn = %x", requestParam->callback_fn);
			_INFO("INFOOOOO  ****  mcc = %s", requestParam->mcc);
			_INFO("INFOOOOO  ****  mnc = %s", requestParam->mnc);
			_INFO("INFOOOOO  ****  transanction_id = %d", requestParam->transaction_id);
			_INFO("INFOOOOO  ****  request Type = %d", requestParam->result.req_type);
			
			dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
			rt = app_control_send_launch_request(app_control, _get_country_list_cb, requestParam);
		}
	} else {
		err = ERROR_INVALID_INPUT_PARAM;
		goto error_label;
	}

	if (app_control != NULL){
		app_control_destroy(app_control);
	}
	return;

error_label:
	_ERR("ERROR :  err = %d ",err);
	if (app_control != NULL){
		app_control_destroy(app_control);
	}
	param->result.req_type = FUNC_GET_COUNTRY_LIST;
	param->result.err_type = err;

	param->callback_fn(param->result);


	return;
}

void
_get_item_list_operation_call(request_param_s *param){
	app_control_h app_control = NULL;
	iap_error_e err  = ERROR_ALL_SUCCESS;
	if(!param){
		err = ERROR_INVALID_INPUT_PARAM;
		goto error_label;
	}
	request_param_s *requestParam = (request_param_s *)calloc(1, sizeof(request_param_s));
	if(!requestParam){
		err = ERROR_ALLOC_FAIL;
		goto error_label;
	}

	memcpy(requestParam, param, sizeof(request_param_s));

	_INFO("INFOOOOO  ****  callback_fn = %x", requestParam->callback_fn);
	_INFO("INFOOOOO  ****  mode = %s", requestParam->mode);
	_INFO("INFOOOOO  ****  start number = %d", requestParam->start_number);
	_INFO("INFOOOOO  ****  end number = %d", requestParam->end_number);
	_INFO("INFOOOOO  ****  item_group_id = %s", requestParam->item_group_id);
	_INFO("INFOOOOO  ****  transanction_id = %d", requestParam->transaction_id);

	int rt = app_control_create(&app_control);
	if (rt == APP_CONTROL_ERROR_NONE){

		char buffer[1024] = {0,};

		_INFO(">>>>>>> IAP_SERVICE_APP_ID : %s", IAP_SERVICE_APP_ID);

		app_control_set_app_id(app_control, IAP_SERVICE_APP_ID);
		app_control_set_operation(app_control, OPERATION_GET_ITEM_LIST);
		app_control_add_extra_data(app_control, PARAM_REQUEST_MODE, param->mode);
		memset(buffer, 0X00, sizeof(buffer));
		snprintf(buffer, sizeof(buffer), "%d", param->transaction_id);
		app_control_add_extra_data(app_control, PARAM_REQUEST_TRANSACTION_ID, buffer);
		memset(buffer, 0X00, sizeof(buffer));
		snprintf(buffer, sizeof(buffer), "%d", param->start_number);
		app_control_add_extra_data(app_control, PARAM_REQUEST_START_NUMBER, buffer);
		memset(buffer, 0X00, sizeof(buffer));
		snprintf(buffer, sizeof(buffer), "%d", param->end_number);
		app_control_add_extra_data(app_control, PARAM_REQUEST_END_NUMBER, buffer);
		app_control_add_extra_data(app_control, PARAM_REQUEST_ITEM_GROUP_ID, param->item_group_id);
		app_control_add_extra_data(app_control, PARAM_REQUEST_LANGUAGE_CD, param->language_cd);
		app_control_add_extra_data(app_control, PARAM_REQUEST_ITEM_TYPE_CD, param->item_type_cd);
		if (param->mcc != NULL){
			app_control_add_extra_data(app_control, PARAM_REQUEST_MCC, param->mcc);
		} else{
			err = ERROR_INVALID_PARAM_MCC;
			goto error_label;
		}

		if (param->mnc != NULL){
			app_control_add_extra_data(app_control, PARAM_REQUEST_MNC, param->mnc);
		} else {
			err = ERROR_INVALID_PARAM_MNC;
			goto error_label;
		}
		
		dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
		rt = app_control_send_launch_request(app_control, _get_item_list_cb, requestParam);
	} else {
		err = ERROR_RESULT_FAIL;
		goto error_label;
	}

	if (app_control != NULL){
		app_control_destroy(app_control);
	}
	return;

error_label:
	_ERR("ERROR : err = %d ", err);

	if (app_control != NULL){
		app_control_destroy(app_control);
	}
	param->result.req_type = FUNC_GET_ITEM_LIST;
	param->result.err_type = err;

	param->callback_fn(param->result);

	return;
}

void
_get_purchased_item_list_operation_call(request_param_s *param){
	iap_error_e err = ERROR_ALL_SUCCESS;
	app_control_h app_control = NULL;
	if(!param){
		err = ERROR_INVALID_INPUT_PARAM;
		goto error_label;
	}

	request_param_s *requestParam = (request_param_s *)calloc(1, sizeof(request_param_s));
	if(!requestParam){
		err = ERROR_ALLOC_FAIL;
		goto error_label;
	}

	memcpy(requestParam, param, sizeof(request_param_s));


	_INFO("INFOOOOO  ****  callback_fn = %x", requestParam->callback_fn);
	_INFO("INFOOOOO  ****  mcc = %s", requestParam->mcc);
	_INFO("INFOOOOO  ****  mnc = %s", requestParam->mnc);
	_INFO("INFOOOOO  ****  mode = %s", requestParam->mode);
	_INFO("INFOOOOO  ****  start number = %d", requestParam->start_number);
	_INFO("INFOOOOO  ****  end number = %d", requestParam->end_number);
	_INFO("INFOOOOO  ****  item_group_id = %s", requestParam->item_group_id);
	_INFO("INFOOOOO  ****  transanction_id = %d", requestParam->transaction_id);
	_INFO("INFOOOOO  ****  item_group_id = %s", requestParam->item_type_cd);
	_INFO("INFOOOOO  ****  language_cd = %s", requestParam->language_cd);
	_INFO("INFOOOOO  ****  start_date = %s", requestParam->start_date);
	_INFO("INFOOOOO  ****  end_date = %s", requestParam->end_date);
	_INFO("INFOOOOO  ****  item_id = %s", requestParam->item_id);
	_INFO("INFOOOOO  ****  item_name = %s", requestParam->item_name);

	int rt = app_control_create(&app_control);
	if (rt == APP_CONTROL_ERROR_NONE){
		char buffer[1024] = {0,};

		app_control_set_app_id(app_control, IAP_SERVICE_APP_ID);
		app_control_set_operation(app_control, OPERATION_GET_PURCHASED_ITEM_LIST);
		app_control_add_extra_data(app_control, PARAM_REQUEST_MODE, param->mode);

		memset(buffer, 0X00, sizeof(buffer));
		snprintf(buffer, sizeof(buffer), "%d", param->transaction_id);
		app_control_add_extra_data(app_control, PARAM_REQUEST_TRANSACTION_ID, buffer);

		memset(buffer, 0X00, sizeof(buffer));
		snprintf(buffer, sizeof(buffer), "%d", param->start_number);
		app_control_add_extra_data(app_control, PARAM_REQUEST_START_NUMBER, buffer);

		memset(buffer, 0X00, sizeof(buffer));
		snprintf(buffer, sizeof(buffer), "%d", param->end_number);
		app_control_add_extra_data(app_control, PARAM_REQUEST_END_NUMBER, buffer);


		app_control_add_extra_data(app_control, PARAM_REQUEST_START_DATE, param->start_date);
		app_control_add_extra_data(app_control, PARAM_REQUEST_END_DATE, param->end_date);
		app_control_add_extra_data(app_control, PARAM_REQUEST_ITEM_GROUP_ID, param->item_group_id);
		app_control_add_extra_data(app_control, PARAM_REQUEST_LANGUAGE_CD, param->language_cd);

		if (param->mcc != NULL){
			app_control_add_extra_data(app_control, PARAM_REQUEST_MCC, param->mcc);
		} else{
			err = ERROR_INVALID_PARAM_MCC;
			goto error_label;
		}

		if (param->mnc != NULL){
			app_control_add_extra_data(app_control, PARAM_REQUEST_MNC, param->mnc);
		} else {
			err = ERROR_INVALID_PARAM_MNC;
			goto error_label;
		}

		
		dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
		rt = app_control_send_launch_request(app_control, _get_purchased_item_list_cb, requestParam);
	} else {
		err = ERROR_RESULT_FAIL;
		goto error_label;
	}

	if (app_control != NULL){
		app_control_destroy(app_control);
	}

	return;

error_label:
	_ERR("ERROR :  err = %d ", err);

	if (app_control != NULL){
		app_control_destroy(app_control);
	}
	param->result.req_type = FUNC_GET_PURCHASED_ITEM_LIST;
	param->result.err_type = err;
	param->callback_fn(param->result);

	return;
}

void
_purchase_operation_call(request_param_s *param){
	iap_error_e err = ERROR_ALL_SUCCESS;
	app_control_h app_control;
	int rt = app_control_create(&app_control);

	if(!param){
		err = ERROR_INVALID_INPUT_PARAM;
		goto error_label;
	}

	request_param_s *requestParam = (request_param_s *)calloc(1, sizeof(request_param_s));
	if(!requestParam){
		err = ERROR_ALLOC_FAIL;
		goto error_label;
	}
	memcpy(requestParam, param, sizeof(request_param_s));

	_INFO("INFOOOOO  ****  callback_fn = %x", requestParam->callback_fn);
	_INFO("INFOOOOO  ****  mcc = %s", requestParam->mcc);
	_INFO("INFOOOOO  ****  mnc = %s", requestParam->mnc);
	_INFO("INFOOOOO  ****  mode = %s", requestParam->mode);
	_INFO("INFOOOOO  ****  start number = %d", requestParam->start_number);
	_INFO("INFOOOOO  ****  end number = %d", requestParam->end_number);
	_INFO("INFOOOOO  ****  item_group_id = %s", requestParam->item_group_id);
	_INFO("INFOOOOO  ****  transanction_id = %d", requestParam->transaction_id);
	_INFO("INFOOOOO  ****  item_group_id = %s", requestParam->item_type_cd);
	_INFO("INFOOOOO  ****  language_cd = %s", requestParam->language_cd);
	_INFO("INFOOOOO  ****  start_date = %s", requestParam->start_date);
	_INFO("INFOOOOO  ****  end_date = %s", requestParam->end_date);
	_INFO("INFOOOOO  ****  item_id = %s", requestParam->item_id);
	_INFO("INFOOOOO  ****  item_name = %s", requestParam->item_name);

	if (rt == APP_CONTROL_ERROR_NONE){
		char buffer[1024] = {0,};
		app_control_set_app_id(app_control, IAP_CLIENT_APP_ID);
		app_control_set_operation(app_control, OPERATION_PURCHASE);
		app_control_add_extra_data(app_control, PARAM_REQUEST_MODE, requestParam->mode);

		memset(buffer, 0X00, sizeof(buffer));
		snprintf(buffer, sizeof(buffer), "%d", requestParam->transaction_id);
		app_control_add_extra_data(app_control, PARAM_REQUEST_TRANSACTION_ID, buffer);
		app_control_add_extra_data(app_control, PARAM_REQUEST_ITEM_ID, requestParam->item_id);
		app_control_add_extra_data(app_control, PARAM_REQUEST_ITEM_GROUP_ID, requestParam->item_group_id);
		app_control_add_extra_data(app_control, PARAM_REQUEST_LANGUAGE_CD, requestParam->language_cd);
		app_control_add_extra_data(app_control, PARAM_REQUEST_ITEM_NAME, requestParam->item_name);
		if (!strcmp("1", requestParam->mode)){
			app_control_add_extra_data(app_control, PARAM_REQUEST_IND_CARRIER_MODE, "1");
		} else {
			app_control_add_extra_data(app_control, PARAM_REQUEST_IND_CARRIER_MODE, "0");
		}
		_INFO("%s = %s", PARAM_REQUEST_ITEM_ID, requestParam->item_id);
		_INFO("%s = %s", PARAM_REQUEST_ITEM_GROUP_ID, requestParam->item_group_id);
		_INFO("%s = %s", PARAM_REQUEST_LANGUAGE_CD, requestParam->language_cd);
		_INFO("%s = %s", PARAM_REQUEST_ITEM_NAME, requestParam->item_name);

		if (requestParam->mcc != NULL){
			app_control_add_extra_data(app_control, PARAM_REQUEST_MCC, requestParam->mcc);
		}
		if (requestParam->mnc != NULL){
			app_control_add_extra_data(app_control, PARAM_REQUEST_MNC, param->mnc);
		}
		
		dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
		rt = app_control_send_launch_request(app_control, _get_purchase_cb, requestParam);

	} else {
		err = ERROR_RESULT_FAIL;
		goto error_label;
	}

	if (app_control != NULL){
		app_control_destroy(app_control);
	}
	return;

error_label:
	_ERR("ERROR :  err = %d ", err);
	if (app_control != NULL){
		app_control_destroy(app_control);
	}
	param->result.req_type = FUNC_GET_PURCHASED_ITEM_LIST;
	param->result.err_type = err;
	param->callback_fn(param->result);

	return;
}

void
_get_char_extra_data(app_control_h app_control, char *target, char *param_name, int num){
	char *data = NULL;
	int rt;
	char buf[100] = {0,};

	if (num >= 0){
		snprintf(buf, sizeof(buf), "%d%s", num, param_name);
	} else {
		snprintf(buf, sizeof(buf), "%s", param_name);
	}

	rt = app_control_get_extra_data(app_control, buf, &data);

	if (rt == APP_CONTROL_ERROR_NONE){
		strcpy(target, data);
		memset(data, 0X00, strlen(data));
	} else {
		strcpy(target, "0");
	}

	if (data != NULL){
		free(data);
	}
	_INFO("_get_extra_data:: %s = %s ", buf, target);
}


void
_get_int_extra_data(app_control_h app_control, int *target, char *param_name, int num){
	char *data = NULL;
	int rt;
	char buf[100] = {0,};

	if (num >= 0){
		snprintf(buf, sizeof(buf), "%d%s", num, param_name);
	} else {
		snprintf(buf, sizeof(buf), "%s", param_name);
	}

	rt = app_control_get_extra_data(app_control, buf, &data);

	if (rt == APP_CONTROL_ERROR_NONE){
		*target = atoi(data);
		memset(data, 0X00, strlen(data));
	} else {
		*target = 0;
	}

	if (data != NULL){
		free(data);
	}

	_INFO("_get_extra_data:: %s = %d ", buf, *target);
}



EXPORT_API  void
get_item_list(request_param_s *param){
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	iap_error_e err = ERROR_ALL_SUCCESS;

	if (!param/* || !param->callback_fn*/){
		return;
	}


	if (param->item_group_id == NULL || !strcmp("", param->item_group_id)){
		dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
		//iap_common_popup(ad->layout, "error", "[Item group ID] is empty");
		err = ERROR_INVALID_ITEM_GRP_ID;
		goto error_label;
	} else if (param->item_type_cd == NULL || !strcmp("", param->item_type_cd)){
		dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
		//iap_common_popup(ad->layout, "error", "[Item type code] is empty");
		err = ERROR_INVALID_ITEM_TYPE_ID;
		goto error_label;
	} else {
		dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
		_get_item_list_operation_call(param);
	}
	return;
error_label:
	_ERR("ERROR :  err = %d ", err);
	param->result.err_type = err;
	param->result.req_type = FUNC_GET_ITEM_LIST;
	sprintf(param->result.item_list_result->transaction_id ,"%d",param->transaction_id);
	param->callback_fn(param->result);

	return;

}

EXPORT_API void
purchase_operation_call(request_param_s *req_param){
	iap_error_e err = ERROR_ALL_SUCCESS;

	if (!req_param || !req_param->callback_fn){
		return;
	}
	//Mandatory param validation needs to be done here.
	if (req_param->transaction_id == 0){
		err = ERROR_INVALID_TRANSACTION_ID;
		goto error_label;
	} else if (req_param->item_id == NULL || !strcmp("", req_param->item_id)){
		err = ERROR_INVALID_ITEM_ID;
		goto error_label;
	} else if (req_param->item_group_id == NULL || !strcmp("", req_param->item_group_id)){
		err = ERROR_INVALID_ITEM_GRP_ID;
		goto error_label;
	} else {
		_purchase_operation_call(req_param);
	}
	return;
error_label:
	_ERR("ERROR :  err = %d ", err);
	req_param->result.err_type = err;
	req_param->result.req_type = FUNC_GET_COUNTRY_LIST;
	sprintf(req_param->result.purchase_result->transaction_id ,"%d",req_param->transaction_id);
	req_param->callback_fn(req_param->result);
	return;
}

EXPORT_API void
get_purchased_item_list(request_param_s *param){
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	iap_error_e err = ERROR_ALL_SUCCESS;

	if (!param || !param->callback_fn){
		return;
	}

	if (param->transaction_id == 0){
		err = ERROR_INVALID_TRANSACTION_ID;
		goto error_label;
	} else if (param->item_group_id == NULL || !strcmp("", param->item_group_id)){
		err = ERROR_INVALID_ITEM_GRP_ID;
		goto error_label;
	} else {
		_get_purchased_item_list_operation_call(param);
	}
	return;

error_label:
	param->result.err_type = err;
	param->result.req_type = FUNC_GET_PURCHASED_ITEM_LIST;
	sprintf(param->result.purchase_result->transaction_id ,"%d",param->transaction_id);
	param->callback_fn(param->result);
	return;


}


EXPORT_API void
get_country_list(request_param_s *req_param)
{
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	iap_error_e err = ERROR_ALL_SUCCESS;


	if (!req_param || !req_param->callback_fn){
		return;
	}

	if (req_param->transaction_id == 0){
		err = ERROR_INVALID_TRANSACTION_ID;
		goto error_label;
	} else {
		_get_country_list_operation_call(req_param);
	}

	return;
error_label:
	req_param->result.err_type = err;
	req_param->result.req_type = FUNC_GET_COUNTRY_LIST;
	sprintf(req_param->result.country_list_result->transaction_id ,"%d",req_param->transaction_id);
	req_param->callback_fn(req_param->result);
	return;
}

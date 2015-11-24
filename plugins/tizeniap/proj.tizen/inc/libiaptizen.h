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
 * @file			libiapunity.h
 * @author			Debi Prasanna Mohanty (debi.m@samsung.com)
 * @version			0.1
 * @brief			This file contains the APIs and the interface structures.
 */


#ifndef _LIBIAPUNITY_H_
#define _LIBIAPUNITY_H_

/**
 * This header file is included to define _EXPORT_.
 */
#include <stdbool.h>
#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <tizen.h>


/*==================================================================================================
		                                         DEFINITIONS
*==================================================================================================*/


#define TIZEN_ENGINEER_MODE

#include <dlog.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "iap.sampleiap"

#ifdef DEBUG
#ifndef _ERR
#define _ERR(fmt, args...) LOGE("[%s:%d] "fmt"\n", __func__, __LINE__, ##args)
#endif

#ifndef _DBG
#define _DBG(fmt, args...) LOGD("[%s:%d] "fmt"\n", __func__, __LINE__, ##args)
#endif

#ifndef _INFO
#define _INFO(fmt, args...) LOGI("[%s:%d] "fmt"\n", __func__, __LINE__, ##args)
#endif
#else
#ifndef _ERR
#define _ERR(...)
#endif

#ifndef _DBG
#define _DBG(...)
#endif

#ifndef _INFO
#define _INFO(...)
#endif
#endif

#define MODE_NORMAL "0"
#define MODE_DEVELOPER "1"


/* IAP App Request parameter */
#define PARAM_REQUEST_MODE 				"_mode"
#define PARAM_REQUEST_TRANSACTION_ID		"_transactionId"
#define PARAM_REQUEST_START_NUMBER			"_startNumber"
#define PARAM_REQUEST_END_NUMBER			"_endNumber"
#define PARAM_REQUEST_ITEM_GROUP_ID		"_itemGroupId"
#define PARAM_REQUEST_LANGUAGE_CD			"_languageCd"
#define PARAM_REQUEST_ITEM_TYPE_CD			"_itemTypeCd"
#define PARAM_REQUEST_MCC					"_mcc"
#define PARAM_REQUEST_MNC					"_mnc"
#define PARAM_REQUEST_START_DATE 			"_startDate"
#define PARAM_REQUEST_END_DATE 			"_endDate"
#define PARAM_REQUEST_ITEM_ID	 			"_itemId"
#define PARAM_REQUEST_ITEM_NAME 			"_itemName"
#define PARAM_REQUEST_IND_CARRIER_MODE 	"_indCarrierMode"


/* IAP App Response parameter */
#define PARAM_RESPONSE_METHOD 				"_method"
#define PARAM_RESPONSE_RESULT 				"_result"
#define PARAM_RESPONSE_RESULT_DESCRIPTION 	"_resultDescription"
#define PARAM_RESPONSE_TRANSACTION_ID 		"_transactionId"
#define PARAM_RESPONSE_START_NUMBER 		"_startNumber"
#define PARAM_RESPONSE_END_NUMBER 			"_endNumber"
#define PARAM_RESPONSE_TOTAL_COUNT 		"_totalCount"
#define PARAM_RESPONSE_COUNTRY_NAME 		"_countryName"
#define PARAM_RESPONSE_MCC 				"_mcc"
#define PARAM_RESPONSE_ITEM_TOTAL_COUNT 	"_itemTotalCount"
#define PARAM_RESPONSE_ITEM_ID 			"_itemId"
#define PARAM_RESPONSE_ITEM_GROUP_ID 		"_itemGroupId"
#define PARAM_RESPONSE_ITEM_NAME 			"_itemName"
#define PARAM_RESPONSE_CURRENCY_UNIT 		"_currencyUnit"
#define PARAM_RESPONSE_UNIT_PRECEDES 		"_unitPrecedes"
#define PARAM_RESPONSE_HAS_PENNY 			"_hasPenny"
#define PARAM_RESPONSE_ITEM_PRICE 			"_itemPrice"
#define PARAM_RESPONSE_ITEM_DOWNLOAD_URL 	"_itemDownloadUrl"
#define PARAM_RESPONSE_ITEM_IMAGE_URL 		"_itemImageUrl"
#define PARAM_RESPONSE_ITEM_DESCRIPTION 	"_itemDescription"
#define PARAM_RESPONSE_RESERVED1 			"_reserved1"
#define PARAM_RESPONSE_RESERVED2 			"_reserved2"
#define PARAM_RESPONSE_ITEM_TYPE_CD 		"_itemTypeCd"
#define PARAM_RESPONSE_ITEM_SUBS_BILL_DURATION_CD 			"_itemSubsBillDurationCd"
#define PARAM_RESPONSE_SUBSCRIPTION_DURATION_MULTIPLIER 	"_subscriptionDurationMultiplier"
#define PARAM_RESPONSE_TIME_STAMP 			"_timeStamp"
#define PARAM_RESPONSE_PAYMENT_ID 			"_paymentId"
#define PARAM_RESPONSE_PURCHASE_DATE 		"_purchaseDate"
#define PARAM_RESPONSE_TICKET_PURCHASE_ID	"_ticketPurchaseId"
#define PARAM_RESPONSE_TICKET_VERIFY_URL	"_ticketVerifyUrl"
#define PARAM_RESPONSE_TICKET_PARAM_1		"_ticketParam1"
#define PARAM_RESPONSE_TICKET_PARAM_2		"_ticketParam2"
#define PARAM_RESPONSE_TICKET_PARAM_3		"_ticketParam3"
#define PARAM_RESPONSE_TICKET_PARAM_4		"_ticketParam4"
#define PARAM_RESPONSE_TICKET_PARAM_5		"_ticketParam5"


#define IAP_SERVICE_APP_ID "org.tizen.inapppurchase.iapservice"
#define IAP_CLIENT_APP_ID "org.tizen.inapppurchase.iapclient"

/* IAP Operation */
#define OPERATION_GET_COUNTRY_LIST "http://tizen.org/appcontrol/operation/iapv2/get_country_list"
#define OPERATION_GET_ITEM_LIST "http://tizen.org/appcontrol/operation/iapv2/get_item_list"
#define OPERATION_GET_PURCHASED_ITEM_LIST "http://tizen.org/appcontrol/operation/iapv2/get_purchased_item_list"
#define OPERATION_PURCHASE "http://tizen.org/appcontrol/operation/iapv2/purchase"


#define NUM_OF_ITEMS 200

/* Item type */
#define ITEM_TYPE_CODE_NON_CONSUMABLE "00"
#define ITEM_TYPE_CODE_CONSUMABLE "01"
#define ITEM_TYPE_CODE_SUBSCRIPTION "02"
#define ITEM_TYPE_CODE_ALL "10"


/* result */
#define RESULT_SUCCESS "0"
#define RESULT_ERROR_200 "200"		//NetworkError
#define RESULT_ERROR_2001 "2001"	//NoApplicationStore
#define RESULT_ERROR_1000 "1000"	//ProcessError
#define RESULT_ERROR_9201 "9201"	//ItemGroupIdNotFound
#define RESULT_ERROR_9207 "9207"	//ItemIdNotFound
#define RESULT_ERROR_9502 "9502"	//InvalidRequestParam
#define RESULT_ERROR_100 "100"		//UserCancel
#define RESULT_ERROR_5600 "5600"	//PGError
#define RESULT_ERROR_9291 "9291"	//No Reorder Item
#define RESULT_ERROR_9292 "9292"	//Update is Progressing

typedef enum {
	FUNC_GET_COUNTRY_LIST = 1,
	FUNC_GET_ITEM_LIST = 2,
	FUNC_GET_PURCHASED_ITEM_LIST = 3,
	FUNC_PURCHASE = 4,
	FUNC_NONE = 0
} iap_menu_e;


typedef enum {
	ERROR_ALL_SUCCESS = 0,
	ERROR_ALLOC_FAIL = 1,
	ERROR_APP_CONTROL_ERROR,
	ERROR_RESULT_FAIL,
	ERROR_RESULT_CANCELLED,
	ERROR_INVALID_INPUT_FPTR,
	ERROR_INVALID_INPUT_PARAM,
	ERROR_INVALID_ITEM_GRP_ID,
	ERROR_INVALID_ITEM_ID,
	ERROR_INVALID_TRANSACTION_ID,
	ERROR_INVALID_ITEM_TYPE_ID,
	ERROR_INVALID_PARAM_MCC,
	ERROR_INVALID_PARAM_MNC,
	ERROR_UNKNOWN_ERROR
} iap_error_e;

/*==================================================================================================
		                                         STRUCTURES
*==================================================================================================*/

typedef struct country {
	char name[100];
	char mcc[8];
} country_s;

typedef struct country_list {
	char method[128];
	char result[16];
	char result_description[256];
	char transaction_id[16];
	int start_number;
	int end_number;
	int total_count;
	country_s *items[NUM_OF_ITEMS];
	int item_size;
} country_list_s;



typedef struct item {
	char item_id[16];
	char item_group_id[16];
	char item_name[256];
	char currency_unit[8];
	char unit_precedes[4];
	char has_penny[4];
	char item_price[16];
	char item_download_url[256];
	char item_image_url[256];
	char item_description[1024];
	char reserved1[256];
	char reserved2[256];
	char payment_id[32];
	char purchase_date[32];
	char item_type_cd[4];
	char item_subs_bill_duration_cd[4];
	char subscription_duration_multiplier[4];
	char time_stamp[16];
	int is_purchased;
	char item_image_path[256];
} item_s;

typedef struct item_list {
	char method[128];
	char result[16];
	char result_description[256];
	char transaction_id[16];
	int start_number;
	int end_number;
	int total_count;
	int item_total_count;
	item_s *items[NUM_OF_ITEMS];
	int item_size;
} item_list_s;

typedef struct purchase {
	char method[128];
	char result[16];
	char result_description[256];
	char transaction_id[16];
	char item_id[16];
	char item_group_id[16];
	char item_name[256];
	char currency_unit[8];
	char unit_precedes[4];
	char has_penny[4];
	char item_price[16];
	char item_download_url[256];
	char item_image_url[256];
	char item_description[1024];
	char reserved1[256];
	char reserved2[256];
	char payment_id[128];
	char ticket_purchase_id[128];
	char ticket_verify_url[512];
	char ticket_param1[128];
	char ticket_param2[128];
	char ticket_param3[128];
	char ticket_param4[128];
	char ticket_param5[128];
	char purchase_date[32];
	char item_type_cd[4];
	char item_subs_bill_duration_cd[4];
	char sub_scription_duration_multiplier[8];
	char time_stamp[32];
} purchase_s;


typedef struct iap_result {
	country_list_s *country_list_result;
	item_list_s *item_list_result;
	purchase_s *purchase_result;
	iap_menu_e req_type;
	iap_error_e err_type;
} iap_result_s;


//C# callback function pointer prototype
typedef void (* cb_fptr)(iap_result_s result);

typedef struct request_parameter{
	char mode[2];
	int transaction_id;
	int start_number;
	int end_number;
	char start_date[12];
	char end_date[12];
	char item_id[16];
	char item_name[256];
	char item_group_id[16];
	char language_cd[8];
	char item_type_cd[4];
	char mcc[8];
	char mnc[8];
	cb_fptr callback_fn;
	iap_result_s result;
}request_param_s;


/*==================================================================================================
                            	         FUNCTION DECLARATIONS
*==================================================================================================*/
/**
*@fn            get_country_list(request_param_s* req_param, iap_result_s, result, void *cb_fptr);
*@brief 		This wrapper API shall give the client the country list.
*@return		Void
*@param[in] 	req_param	 This is the request that the application needs to populate
*/
EXPORT_API  void
get_country_list(request_param_s *req_param);

/**
*@fn            get_item_list(request_param_s req_param);
*@brief 		This wrapper API shall give the client the item list.
*@return		Void
*@param[in] 	req_param	 This is the request that the application needs to populate
*/
EXPORT_API  void
get_item_list(request_param_s *req_param);


/**
*@fn            get_purchased_item_list(request_param_s req_param);
*@brief 		This wrapper API shall give the client the purchased item list.
*@return		Void
*@param[in] 	req_param	 This is the request that the application needs to populate
*/
EXPORT_API  void
get_purchased_item_list(request_param_s *req_param);


/**
*@fn            purchase_operation_call(request_param_s req_param);
*@brief 		This wrapper API shall allow the client to make a purchase.
*@return		Void
*@param[in] 	req_param	 This is the request that the application needs to populate
*/
EXPORT_API  void
purchase_operation_call(request_param_s *req_param);

#endif // _LIBIAPUNITY_H_


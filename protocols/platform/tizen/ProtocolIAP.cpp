/****************************************************************************
Copyright (c) 2012-2013 cocos2d-x.org

http://www.cocos2d-x.org

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/
#include "ProtocolIAP.h"
#include "PluginUtils.h"
#include "PluginTizenData.h"
//#include "tizenIap.h"

namespace cocos2d { namespace plugin {

extern "C" {
/*	JNIEXPORT void JNICALL Java_org_cocos2dx_plugin_IAPWrapper_nativeOnPayResult(JNIEnv*  env, jobject thiz, jstring className, jint ret, jstring msg)
	{
		std::string strMsg = PluginJniHelper::jstring2string(msg);
		std::string strClassName = PluginJniHelper::jstring2string(className);
		PluginProtocol* pPlugin = PluginUtils::getPluginPtr(strClassName);
		PluginUtils::outputLog("ProtocolIAP", "nativeOnPayResult(), Get plugin ptr : %p", pPlugin);
		if (pPlugin != NULL)
		{
			PluginUtils::outputLog("ProtocolIAP", "nativeOnPayResult(), Get plugin name : %s", pPlugin->getPluginName());
			ProtocolIAP* pIAP = dynamic_cast<ProtocolIAP*>(pPlugin);
			if (pIAP != NULL)
			{
				pIAP->onPayResult((PayResultCode) ret, strMsg.c_str());
			}
			else
			{
				ProtocolIAP::ProtocolIAPCallback callback = pIAP->getCallback();
				if(callback)
					callback(ret, strMsg);
			}
		}
	}
*/
}

bool ProtocolIAP::_paying = false;
ProtocolIAP *g_TizenIAP = NULL;
int
_make_transaction_id(){
	srand(time( NULL));
	return (rand() % 1000000 + 1);
}

void GetResultCB(iap_result_s result)
{
	if(g_TizenIAP)
	{
		g_TizenIAP->GetResult(result);
	}
}
ProtocolIAP::ProtocolIAP()
: _listener(NULL)
{
	g_TizenIAP = this;
	//g_pTizenIAP = new TizenIAP();

}

ProtocolIAP::~ProtocolIAP()
{
	//if(g_pTizenIAP)
	{
	//	delete g_pTizenIAP;
	//	g_pTizenIAP = NULL;
	}
}

TProductList ProtocolIAP::GetList(iap_result_s &result)
{
	TProductList list;
	TProductInfo typeInfo;
	switch(result.req_type)
	{
	case FUNC_GET_COUNTRY_LIST:
		{
			typeInfo["typeInfo"] = "FUNC_GET_COUNTRY_LIST";
			list.push_back(typeInfo);

			TProductInfo prodInfo;
			char buf[256];
			prodInfo["method"] = result.country_list_result->method;
			prodInfo["result"] = result.country_list_result->result;
			prodInfo["result_description"] = result.country_list_result->result_description;
			prodInfo["transaction_id"] = result.country_list_result->transaction_id;
			sprintf(buf, "%d", result.country_list_result->start_number);
			prodInfo["start_number"] = buf;
			sprintf(buf, "%d", result.country_list_result->end_number);
			prodInfo["end_number"] = buf;
			list.push_back(prodInfo);

			if(result.country_list_result->total_count<NUM_OF_ITEMS)
			{
				for(int i=0; i<result.country_list_result->total_count; i++)
				{
					TProductInfo item;
					item["name"] = result.country_list_result->items[i]->name;
					item["mcc"] = result.country_list_result->items[i]->mcc;
					list.push_back(item);
				}
			}
		}
		break;
	case FUNC_GET_ITEM_LIST:
		{
			typeInfo["typeInfo"] = "FUNC_GET_ITEM_LIST";
			list.push_back(typeInfo);

			TProductInfo prodInfo;
			char buf[256];
			prodInfo["method"] = result.item_list_result->method;
			prodInfo["result"] = result.item_list_result->result;
			prodInfo["result_description"] = result.item_list_result->result_description;
			prodInfo["transaction_id"] = result.item_list_result->transaction_id;
			sprintf(buf, "%d", result.item_list_result->start_number);
			prodInfo["start_number"] = buf;
			sprintf(buf, "%d", result.item_list_result->end_number);
			prodInfo["end_number"] = buf;
			list.push_back(prodInfo);
			//TProductInfo item;
			//item["item_id"] = "100000000012";
			//item["item_group_id"] = "1000";
			//item["item_name"] = "test";
			//list.push_back(item);
			if(result.item_list_result->item_total_count<NUM_OF_ITEMS)
			{
				for(int i=0; i<result.item_list_result->item_total_count; i++)
				{
					TProductInfo item;
					item["item_id"] = result.item_list_result->items[i]->item_id;
					item["item_group_id"] = result.item_list_result->items[i]->item_group_id;
					item["item_name"] = result.item_list_result->items[i]->item_name;
					item["currency_unit"] = result.item_list_result->items[i]->currency_unit;
					item["unit_precedes"] = result.item_list_result->items[i]->unit_precedes;
					item["has_penny"] = result.item_list_result->items[i]->has_penny;
					item["item_price"] = result.item_list_result->items[i]->item_price;
					item["item_download_url"] = result.item_list_result->items[i]->item_download_url;
					item["item_image_url"] = result.item_list_result->items[i]->item_image_url;
					item["item_description"] = result.item_list_result->items[i]->item_description;
					item["reserved1"] = result.item_list_result->items[i]->reserved1;
					item["reserved2"] = result.item_list_result->items[i]->reserved2;
					item["payment_id"] = result.item_list_result->items[i]->payment_id;
					item["purchase_date"] = result.item_list_result->items[i]->purchase_date;
					item["item_type_cd"] = result.item_list_result->items[i]->item_type_cd;
					item["item_subs_bill_duration_cd"] = result.item_list_result->items[i]->item_subs_bill_duration_cd;
					item["subscription_duration_multiplier"] = result.item_list_result->items[i]->subscription_duration_multiplier;
					item["time_stamp"] = result.item_list_result->items[i]->time_stamp;
					item["item_image_path"] = result.item_list_result->items[i]->item_image_path;
					sprintf(buf, "%d", result.item_list_result->items[i]->is_purchased);
					prodInfo["end_number"] = buf;

					list.push_back(item);
				}
			}
		}
		break;
	case FUNC_GET_PURCHASED_ITEM_LIST:
		{
			typeInfo["typeInfo"] = "FUNC_GET_PURCHASED_ITEM_LIST";
			list.push_back(typeInfo);

			TProductInfo prodInfo;
			prodInfo["request type"] = "FUNC_GET_PURCHASED_ITEM_LIST";
			prodInfo["method"] = result.purchase_result->method;
			prodInfo["result"] = result.purchase_result->result;
			prodInfo["result_description"] = result.purchase_result->result_description;
			prodInfo["transaction_id"] = result.purchase_result->transaction_id;
			prodInfo["item_id"] = result.purchase_result->item_id;
			prodInfo["item_group_id"] = result.purchase_result->item_group_id;
			prodInfo["item_name"] = result.purchase_result->item_name;
			prodInfo["currency_unit"] = result.purchase_result->currency_unit;
			prodInfo["unit_precedes"] = result.purchase_result->unit_precedes;

			prodInfo["has_penny"] = result.purchase_result->has_penny;
			prodInfo["item_price"] = result.purchase_result->item_price;
			prodInfo["item_download_url"] = result.purchase_result->item_download_url;
			prodInfo["item_image_url"] = result.purchase_result->item_image_url;
			prodInfo["item_description"] = result.purchase_result->item_description;
			prodInfo["reserved1"] = result.purchase_result->reserved1;
			prodInfo["reserved2"] = result.purchase_result->reserved2;
			prodInfo["payment_id"] = result.purchase_result->payment_id;
			prodInfo["ticket_purchase_id"] = result.purchase_result->ticket_purchase_id;

			prodInfo["ticket_verify_url"] = result.purchase_result->ticket_verify_url;
			prodInfo["ticket_param1"] = result.purchase_result->ticket_param1;
			prodInfo["ticket_param2"] = result.purchase_result->ticket_param2;
			prodInfo["ticket_param3"] = result.purchase_result->ticket_param3;
			prodInfo["ticket_param4"] = result.purchase_result->ticket_param4;
			prodInfo["ticket_param5"] = result.purchase_result->ticket_param5;
			prodInfo["purchase_date"] = result.purchase_result->purchase_date;
			prodInfo["item_type_cd"] = result.purchase_result->item_type_cd;
			prodInfo["item_subs_bill_duration_cd"] = result.purchase_result->item_subs_bill_duration_cd;
			prodInfo["sub_scription_duration_multiplier"] = result.purchase_result->sub_scription_duration_multiplier;
			prodInfo["time_stamp"] = result.purchase_result->time_stamp;

			list.push_back(prodInfo);
		}
		break;
	default:
		break;
	}
	if(result.country_list_result)
	{
		for(int i=0; i<NUM_OF_ITEMS; i++)
		{
			if(result.country_list_result->items[i])
			{
				delete result.country_list_result->items[i];
				result.country_list_result->items[i] = nullptr;
			}
		}
		delete result.country_list_result;
		result.country_list_result = nullptr;
	}
	if(result.item_list_result)
	{
		for(int i=0; i<NUM_OF_ITEMS; i++)
		{
			if(result.item_list_result->items[i])
			{
				delete result.item_list_result->items[i];
				result.item_list_result->items[i] = nullptr;
			}
		}
		delete result.item_list_result;
		result.item_list_result = nullptr;
	}
	if(result.purchase_result)
	{
		delete result.purchase_result;
		result.purchase_result = nullptr;
	}
	return list;
}

void ProtocolIAP::GetResult(iap_result_s &result)
{
	IAPProductRequest reqRet = RequestFail;
	PayResultCode payRet = kPayFail;
	iap_error_e err_type = result.err_type;
	char *msg = NULL;
	switch(err_type)
	{
	case ERROR_ALL_SUCCESS:
		payRet = kPaySuccess;
		msg = "Success";
		break;
	case ERROR_ALLOC_FAIL:
		payRet = kPayFail;
		msg = "Failed";
		break;
	case ERROR_APP_CONTROL_ERROR:
		payRet = kPayFail;
		msg = "Failed";
		break;
	case ERROR_RESULT_FAIL:
		payRet = kPayFail;
		msg = "Failed";
		break;
	case ERROR_RESULT_CANCELLED:
		payRet = kPayCancel;
		msg = "Canceled";
		break;
	case ERROR_INVALID_INPUT_FPTR:
		break;
	case ERROR_INVALID_INPUT_PARAM:
		break;
	case ERROR_INVALID_ITEM_GRP_ID:
		break;
	case ERROR_INVALID_ITEM_ID:
		break;
	case ERROR_INVALID_TRANSACTION_ID:
		break;
	case ERROR_INVALID_ITEM_TYPE_ID:
		break;
	case ERROR_INVALID_PARAM_MCC:
		break;
	case ERROR_INVALID_PARAM_MNC:
		break;
	case ERROR_UNKNOWN_ERROR:
		break;
	default:
		break;
	}

	switch(result.req_type)
	{
	case FUNC_GET_COUNTRY_LIST:
	case FUNC_GET_ITEM_LIST:
	case FUNC_GET_PURCHASED_ITEM_LIST:
	    if (_listener)
	    {
	    	TProductList prodList = GetList(result);
	    	_listener->onRequestProductsResult(reqRet, prodList);
	    }
	    break;
	case FUNC_PURCHASE:
		onPayResult(payRet, msg);
		break;
	default:
		break;
	}
}

void ProtocolIAP::configDeveloperInfo(TIAPDeveloperInfo devInfo)
{
    if (devInfo.empty())
    {
        PluginUtils::outputLog("ProtocolIAP", "The developer info is empty!");
        return;
    }
    else
    {
     	//request the products information.
    	if(devInfo.find("get country list")!=devInfo.end())
    	{
			dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
			request_param_s *param = (request_param_s *)malloc(sizeof(request_param_s));
			param->transaction_id = _make_transaction_id();

			param->callback_fn = GetResultCB;
			result.country_list_result = new country_list_s;
			for(int i=0; i<NUM_OF_ITEMS; i++)
			{
				result.country_list_result->items[i] = new country_s;
			}

			result.item_list_result = nullptr;
			result.purchase_result = nullptr;
			param->result = result;
    		get_country_list(param);
    	}
    	else if(devInfo.find("get item list")!=devInfo.end())
    	{
			dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
			request_param_s *param = (request_param_s *)malloc(sizeof(request_param_s));
			param->transaction_id = _make_transaction_id();
			strcpy(param->item_group_id, devInfo["item_group_id"].c_str());
			strcpy(param->item_type_cd, devInfo["item_type_cd"].c_str());
			strcpy(param->language_cd, devInfo["language_cd"].c_str());
			param->start_number = 1;
			param->end_number = NUM_OF_ITEMS;
			strcpy(param->start_date, devInfo["start_date"].c_str());
			strcpy(param->end_date, devInfo["end_date"].c_str());
			strcpy(param->mode, devInfo["mode"].c_str());
			strcpy(param->mcc, devInfo["mcc"].c_str());
			strcpy(param->mnc, devInfo["mnc"].c_str());
			strcpy(param->item_id, devInfo["item_id"].c_str());
			strcpy(param->item_name, devInfo["item_name"].c_str());

			param->callback_fn = GetResultCB;
			result.country_list_result = nullptr;
			result.item_list_result = new item_list_s;
			for(int i=0; i<NUM_OF_ITEMS; i++)
			{
				result.item_list_result->items[i] = new item_s;
			}
			result.purchase_result = nullptr;
			param->result = result;
			get_item_list(param);
    	}
    	else if(devInfo.find("get purchased list")!=devInfo.end())
    	{
			dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
			request_param_s *param = (request_param_s *)malloc(sizeof(request_param_s));
			param->transaction_id = _make_transaction_id();
			strcpy(param->item_group_id, devInfo["item_group_id"].c_str());
			strcpy(param->item_type_cd, devInfo["item_type_cd"].c_str());
			strcpy(param->language_cd, devInfo["language_cd"].c_str());
			param->start_number = 1;
			param->end_number = NUM_OF_ITEMS;
			strcpy(param->start_date, devInfo["start_date"].c_str());
			strcpy(param->end_date, devInfo["end_date"].c_str());
			strcpy(param->mode, devInfo["mode"].c_str());
			strcpy(param->mcc, "");
			strcpy(param->mnc, "");
			strcpy(param->item_id, "");
			strcpy(param->item_name, "");

			param->callback_fn = GetResultCB;
			result.country_list_result = nullptr;
			result.item_list_result = nullptr;
			result.purchase_result = new purchase_s;
			param->result = result;
			get_purchased_item_list(param);
    	}
    }
}

void ProtocolIAP::payForProduct(TProductInfo info)
{
    if (_paying)
    {
        PluginUtils::outputLog("ProtocolIAP", "Now is paying");
        return;
    }

    if (info.empty())
    {
        if (NULL != _listener)
        {
            onPayResult(kPayFail, "Product info error");
        }
        PluginUtils::outputLog("ProtocolIAP", "The product info is empty!");
        return;
    }
    else
    {
        _paying = true;
        _curInfo = info;
        request_param_s *param = (request_param_s *)malloc(sizeof(request_param_s));
		strcpy(param->item_group_id, info["item_group_id"].c_str());
		strcpy(param->item_type_cd, info["item_type_cd"].c_str());
		strcpy(param->language_cd, info["language_cd"].c_str());
		strcpy(param->item_id, info["item_id"].c_str());
		strcpy(param->item_name, info["item_name"].c_str());
		param->start_number = 1;
		param->end_number = NUM_OF_ITEMS;
		strcpy(param->start_date, info["start_date"].c_str());
		strcpy(param->end_date, info["end_date"].c_str());
		strcpy(param->mode, info["mode"].c_str());
		strcpy(param->mcc, "");
		strcpy(param->mnc, "");

    	param->callback_fn = GetResultCB;
    	result.country_list_result = new country_list_s;
    	result.item_list_result = new item_list_s;
    	result.purchase_result = new purchase_s;
    	param->result = result;
        purchase_operation_call(param);
    }
}

void ProtocolIAP::payForProduct(TProductInfo info, ProtocolIAPCallback cb)
{
	_callback = cb;
	payForProduct(info);
}

void ProtocolIAP::setResultListener(PayResultListener* pListener)
{
	_listener = pListener;
//	g_pTizenIAP->SetListener(_listener);
}

void ProtocolIAP::onPayResult(PayResultCode ret, const char* msg)
{
    _paying = false;
    if (_listener)
    {
    	_listener->onPayResult(ret, msg, _curInfo);
    }
    else
    {
        PluginUtils::outputLog("ProtocolIAP", "Result listener is null!");
    }
    _curInfo.clear();
    PluginUtils::outputLog("ProtocolIAP", "Pay result is : %d(%s)", (int) ret, msg);
}

}} // namespace cocos2d { namespace plugin {

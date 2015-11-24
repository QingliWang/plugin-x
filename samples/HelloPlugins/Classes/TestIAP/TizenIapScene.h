#ifndef __TIZEN_IAP_SCENE_H__
#define __TIZEN_IAP_SCENE_H__

#include "cocos2d.h"
#include "ui/UICheckBox.h"
#include "ui/UIButton.h"
#include "ui/UITextField.h"
#include "ui/UIScrollView.h"
#include "ProtocolIAP.h"

using namespace std;


USING_NS_CC;

using namespace cocos2d::plugin;
using namespace cocos2d::ui;

//#define IAP_DEBUG


class CIapNormalLayer;
class CIapDevelopLayer;
class CIapPopLayer;

class CIapLayer : public Layer, public PayResultListener
{
public:
	typedef enum _PopLayerType
	{
		MccMncClickPopType, 
		ItemTypeCodeClickPopType, 
		GetItemListClickPopType, 
		GetPurchasedClickPopType, 
		PayClickType, 
	} PopLayerType;
	
	virtual bool init() override;
	CREATE_FUNC(CIapLayer);

	void checkboxSelectedEvent(Ref* pSender, CheckBoxEventType type);
	
    virtual void onRequestProductsResult(IAPProductRequest ret, TProductList info);   // 'MCC/MNC/get_item_list/get_purchased' clicked response
	virtual void onPayResult(PayResultCode ret, const char* msg, TProductInfo info);  // 'buy' clicked response

	CIapNormalLayer *getNormalLayer() { return normalLayer; }
	CIapDevelopLayer *getDevelopLayer() { return developLayer; }
	CIapPopLayer *getPopLayer() { return popLayer; }
	ProtocolIAP *getProtoIAP() { return protoIAP; }

protected:
	CIapLayer();
	virtual ~CIapLayer();

private:
	void layout();

private:
	Label *labelMode;
	
	CheckBox *checkboxNormal;
	Label *labelNormal;
	
	CheckBox *checkboxDeveloper;
	Label *labelDeveloper;
	
	CheckBox *checkboxSelected;  // use for radio

	CIapNormalLayer *normalLayer;
	CIapDevelopLayer *developLayer;
	CIapPopLayer *popLayer;
	
private:
	ProtocolIAP *protoIAP;
};

class CIapPopLayer : public Layer
{
public:	
    virtual bool init() override;
	CREATE_FUNC(CIapPopLayer);

	void showNotice(string text);

	void show(CIapLayer::PopLayerType type);
	void show(CIapLayer::PopLayerType type, TProductList &info, IAPProductRequest ret);
	void show(CIapLayer::PopLayerType type, TProductInfo &info, PayResultCode ret, const char* msg);
	
	void hide();

protected:
	CIapPopLayer();
	virtual ~CIapPopLayer();

private:
	void showRetMccMnc(TProductList &info, IAPProductRequest ret);
	void showRetGetItemList(TProductList &info, IAPProductRequest ret);
	void showRetGetPurchased(TProductList &info, IAPProductRequest ret);
	void showRetPay(TProductInfo &info, PayResultCode ret, const char* msg);
	void showRetItemTypeCode();  // don't need network

	void showLoading();

private:
	ScrollView *scrollView;
	Label *labelNotice;
};

class CIapNormalLayer : public Layer
{
public:
	virtual bool init() override;
	CREATE_FUNC(CIapNormalLayer);

protected:
	CIapNormalLayer();
	virtual ~CIapNormalLayer();
	
private:
	void layout();
	void getIapDeveloperInfo(TIAPDeveloperInfo &info);

private:
	bool onTouchBegan(Touch* touch, Event* event);
	bool onTouchEnd(Touch* touch, Event* event);

private:
	Button *buttonGetItemList;
	Button *buttonGetPurchased;
private:
	Vec2 touchBeginPos;
};

class CIapDevelopLayer : public Layer
{
public:
	virtual bool init() override;
	CREATE_FUNC(CIapDevelopLayer);
	
	void setMccClickText(const string &text) { labelMccClick->setString(text); }
	const string &getMccClickText() { return labelMccClick->getString(); }
	
	void setMncClickText(const string &text) { labelMncClick->setString(text); }
	const string &getMncClickText() { return labelMncClick->getString(); }
	
	void setItemgroupIDClickText(const string &text) { textItemgroupIDClick->setString(text); }
	const string &getItemgroupIDClickText() { textItemgroupIDClick->getString(); }
	
	void setItemtypecodeClickText(const string &text) { labelItemtypecodeClick->setString(text); }
	const string &getItemtypecodeClickText() { labelItemtypecodeClick->getString(); }
	
protected:
	CIapDevelopLayer();
	virtual ~CIapDevelopLayer();
	
private:
	void layout();
	void getIapDeveloperInfo(TIAPDeveloperInfo &info);

private:
	bool onTouchBegan(Touch* touch, Event* event);
	bool onTouchEnd(Touch* touch, Event* event);

private:
	Label *labelMcc;
	Label *labelMccClick;
	
	Label *labelMnc;
	Label *labelMncClick;
	
	Label *labelItemgroupID;
	TextField *textItemgroupIDClick;
	
	Label *labelItemtypecode;
	Label *labelItemtypecodeClick;
	
	Button *buttonGetItemList;
	Button *buttonGetPurchased;
private:
	Vec2 touchBeginPos;
};

class CTizenIapScene : public Layer
{

public:
	virtual bool init() override;
	CREATE_FUNC(CTizenIapScene);
	
	static Scene* scene();
	
protected:
	CTizenIapScene();
	~CTizenIapScene();

private:
	void rotateCallback(Ref* sender);

private:
	CIapLayer *iapLayer;
};


#endif



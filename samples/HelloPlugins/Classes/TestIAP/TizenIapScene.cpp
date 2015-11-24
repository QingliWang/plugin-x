#include <dlog.h>

#include "ui/CocosGUI.h"
#include "TizenIapScene.h"
#include "PluginManager.h"
#include "AppMacros.h"


/********************* CTizenIapScene *********************/

CTizenIapScene::CTizenIapScene()
	: iapLayer(nullptr)
{
}

CTizenIapScene::~CTizenIapScene()
{
	if (iapLayer != nullptr)
		removeChild(iapLayer);
}

bool CTizenIapScene::init()
{
	if (!Layer::init())
		return false;

	iapLayer = CIapLayer::create();
	if (iapLayer == nullptr)
		return false;

	addChild(iapLayer);
	
	return true;
}

Scene* CTizenIapScene::scene()
{
	auto scene = Scene::create();
	auto layer = CTizenIapScene::create();
	
	scene->addChild(layer);
	
	return scene;
}

void CTizenIapScene::rotateCallback(Ref* sender)
{
}

/********************* CIapLayer *********************/

CIapLayer::CIapLayer()
	: labelMode(nullptr), checkboxNormal(nullptr), labelNormal(nullptr), 
	  checkboxDeveloper(nullptr), labelDeveloper(nullptr), checkboxSelected(nullptr), 
	  normalLayer(nullptr), developLayer(nullptr), popLayer(nullptr), protoIAP(nullptr)
{
}

CIapLayer::~CIapLayer()
{
	if (labelMode != nullptr)
		removeChild(labelMode);
	if (checkboxNormal != nullptr)
		removeChild(checkboxNormal);
	if (labelNormal != nullptr)
		removeChild(labelNormal);
	if (checkboxDeveloper != nullptr)
		removeChild(checkboxDeveloper);
	if (labelDeveloper != nullptr)
		removeChild(labelDeveloper);
	if (normalLayer != nullptr)
		removeChild(normalLayer);
	if (developLayer != nullptr)
		removeChild(developLayer);
	if (popLayer != nullptr)
		removeChild(popLayer);
	if (protoIAP != nullptr)
		delete protoIAP;
}

bool CIapLayer::init()
{
	if (!Layer::init())
		return false;

	// label
	labelMode = Label::createWithTTF("Mode", "fonts/arial.ttf", 48);
	labelNormal = Label::createWithTTF("Normal", "fonts/arial.ttf", 48);
	labelDeveloper = Label::createWithTTF("Developer", "fonts/arial.ttf", 48);

	if (labelMode == nullptr || labelNormal == nullptr || labelDeveloper == nullptr)
		return false;

	addChild(labelMode, 0);
	addChild(labelNormal, 0);
	addChild(labelDeveloper, 0);

	// check box
	checkboxNormal = CheckBox::create("image/check_box_normal.png", "image/check_box_active.png");
	checkboxDeveloper = CheckBox::create("image/check_box_normal.png", "image/check_box_active.png");

	if (checkboxNormal == nullptr || checkboxDeveloper == nullptr)
		return false;

	addChild(checkboxNormal, 0);
	addChild(checkboxDeveloper, 0);

	checkboxNormal->addEventListenerCheckBox(
		this, (SEL_SelectedStateEvent)(&CIapLayer::checkboxSelectedEvent));
	checkboxDeveloper->addEventListenerCheckBox(
		this, (SEL_SelectedStateEvent)(&CIapLayer::checkboxSelectedEvent));

	// son layer
	normalLayer = CIapNormalLayer::create();
	developLayer = CIapDevelopLayer::create();
	popLayer = CIapPopLayer::create();

	if (normalLayer == nullptr || developLayer == nullptr || popLayer == nullptr)
		return false;

	addChild(normalLayer);
	addChild(developLayer);
	addChild(popLayer);

	layout();

	// iap
	protoIAP = dynamic_cast<ProtocolIAP *>(PluginManager::getInstance()->loadPlugin("IAPTizen"));
	if (protoIAP == nullptr)
		return false;
	
	protoIAP->setResultListener(this);
	protoIAP->setDebugMode(true);

	// init state
	checkboxNormal->setSelected(true);
	checkboxSelected = checkboxNormal;

	developLayer->setVisible(false);
	popLayer->setVisible(false);

	return true;
}

void CIapLayer::layout()
{
	auto visibleSize = Director::getInstance()->getVisibleSize();

	float HD1 = 16.0f;  // horizontal delta
	float HD2 = 8.0f;   // horizontal delta
	float VD = visibleSize.height * 0.9;  // vertical delta
	float totalWidth, posX;
	Vec2 pos;

	// Mode  �� Normal  �� Developer
	//     HD1 HD2    HD1 HD2
	totalWidth = labelMode->getContentSize().width
				+ labelNormal->getContentSize().width
				+ labelDeveloper->getContentSize().width
				+ checkboxNormal->getContentSize().width
				+ checkboxDeveloper->getContentSize().width
				+ 2*HD1 + 2*HD2;

	posX = (visibleSize.width - totalWidth)/2 + labelMode->getContentSize().width / 2;
	pos.set(posX, VD);
	labelMode->setPosition(pos);
	labelMode->setColor(Color3B::RED);
	
	posX += (labelMode->getContentSize().width + checkboxNormal->getContentSize().width)/2 + HD1;
	pos.set(posX, VD);
	checkboxNormal->setPosition(pos);

	posX += (checkboxNormal->getContentSize().width + labelNormal->getContentSize().width)/2 + HD2;
	pos.set(posX, VD);
	labelNormal->setPosition(pos);
	
	posX += (labelNormal->getContentSize().width + checkboxDeveloper->getContentSize().width)/2 + HD1;
	pos.set(posX, VD);
	checkboxDeveloper->setPosition(pos);
	
	posX += (checkboxDeveloper->getContentSize().width + labelDeveloper->getContentSize().width)/2 + HD2;
	pos.set(posX, VD);
	labelDeveloper->setPosition(pos);
}

void CIapLayer::checkboxSelectedEvent(Ref* pSender, CheckBoxEventType type)
{
	switch (type)
	{
	case CHECKBOX_STATE_EVENT_SELECTED:
		if (dynamic_cast<CheckBox*>(pSender) != checkboxSelected)
		{
			checkboxSelected->setSelected(false);
			
			if (dynamic_cast<CheckBox*>(pSender) == checkboxNormal)
			{
				normalLayer->setVisible(true);
				developLayer->setVisible(false);
			}
			else if (dynamic_cast<CheckBox*>(pSender) == checkboxDeveloper)
			{
				normalLayer->setVisible(false);
				developLayer->setVisible(true);
			}

			popLayer->hide();
		}
		break;
	case CHECKBOX_STATE_EVENT_UNSELECTED:
		break;
	default:
		break;
	}
	
	checkboxSelected = dynamic_cast<CheckBox *>(pSender);
	checkboxSelected->setSelected(true);
}

void CIapLayer::onRequestProductsResult(IAPProductRequest ret, TProductList info)
{
	PopLayerType type;
	
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	getPopLayer()->showNotice("");

	if ((*info.begin())["typeInfo"] == "FUNC_GET_COUNTRY_LIST")
		type = MccMncClickPopType;
	else if ((*info.begin())["typeInfo"] == "FUNC_GET_ITEM_LIST")
		type = GetItemListClickPopType;
	else if ((*info.begin())["typeInfo"] == "FUNC_GET_PURCHASED_ITEM_LIST")
		type = GetPurchasedClickPopType;
	else {
		dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d: unkown ProductList type !", __FUNCTION__, __LINE__);
		return;
	}
	
	popLayer->show(type, info, ret);
}

void CIapLayer::onPayResult(PayResultCode ret, const char* msg, TProductInfo info)
{
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	popLayer->show(PayClickType, info, ret, msg);
}

/********************* CIapNormalLayer *********************/

CIapNormalLayer::CIapNormalLayer()
	: buttonGetItemList(nullptr), buttonGetPurchased(nullptr)
{
}

CIapNormalLayer::~CIapNormalLayer()
{
	if (buttonGetItemList)
		removeChild(buttonGetItemList);
	if (buttonGetPurchased)
		removeChild(buttonGetPurchased);
}

bool CIapNormalLayer::init()
{
	if (!Layer::init())
		return false;

	// button
	buttonGetItemList = Button::create("image/button_normal.png", "image/button_active.png");
	buttonGetPurchased = Button::create("image/button_normal.png", "image/button_active.png");

	if (buttonGetItemList == nullptr || buttonGetPurchased == nullptr)
		return false;

	addChild(buttonGetItemList);
	addChild(buttonGetPurchased);

	layout();

	// listener
	auto listener = EventListenerTouchOneByOne::create();
	listener->onTouchBegan = CC_CALLBACK_2(CIapNormalLayer::onTouchBegan, this);
	listener->onTouchEnded = CC_CALLBACK_2(CIapNormalLayer::onTouchEnd, this);
	Director::getInstance()->getEventDispatcher()->addEventListenerWithSceneGraphPriority(listener, this);
	
	buttonGetItemList->addClickEventListener([=](Ref* sender) {
		TIAPDeveloperInfo pDevInfo;
		ProtocolIAP *protoIAP = (dynamic_cast<CIapLayer *>(getParent()))->getProtoIAP();
		CIapPopLayer *popLayer = (dynamic_cast<CIapLayer *>(getParent()))->getPopLayer();
		
		dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
		
		pDevInfo["get item list"] = "get item list";
		getIapDeveloperInfo(pDevInfo);

		popLayer->showNotice("waiting ...");
		protoIAP->configDeveloperInfo(pDevInfo);
	});

	buttonGetPurchased->addClickEventListener([=](Ref* sender) {
		TIAPDeveloperInfo pDevInfo;
		ProtocolIAP *protoIAP = (dynamic_cast<CIapLayer *>(getParent()))->getProtoIAP();
		CIapPopLayer *popLayer = (dynamic_cast<CIapLayer *>(getParent()))->getPopLayer();
		
		dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
		
		pDevInfo["get purchased list"] = "get purchased list";
		getIapDeveloperInfo(pDevInfo);
		
		popLayer->showNotice("waiting ...");
		protoIAP->configDeveloperInfo(pDevInfo);
	});
	
	return true;
}

void CIapNormalLayer::layout()
{
	Vec2 pos;
	auto visibleSize = Director::getInstance()->getVisibleSize();
	
	pos.set(visibleSize.width/2 - buttonGetItemList->getContentSize().width / 2, visibleSize.height * 0.5);
	buttonGetItemList->setScale(2);
	buttonGetItemList->setTitleText("get_item_list");
	buttonGetItemList->setTitleFontSize(24);
	buttonGetItemList->setPosition(pos);
	
	pos.set(visibleSize.width/2 - buttonGetItemList->getContentSize().width/2, visibleSize.height * 0.2);
	buttonGetPurchased->setScale(2);
	buttonGetPurchased->setTitleText("get_purchased");
	buttonGetPurchased->setTitleFontSize(24);
	buttonGetPurchased->setPosition(pos);
}

void CIapNormalLayer::getIapDeveloperInfo(TIAPDeveloperInfo &info)
{
	info["mode"] = "1";
	info["TizenAppKey"] = "TizenAppKey";
	info["language_cd"] = "ENG";
	info["start_date"] = "2014-01-01";
	info["end_date"] = "2020-12-31";
	info["start_number"] = "1";
	info["end_number"] = "200";

	info["mcc"] = "404";
	info["mnc"] = "01";
	info["item_group_id"] = "100000070614";
	info["item_type_cd"] = "10";
	
	info["item_id"] = "000000581522";
	info["item_name"] = "item1";
}

bool CIapNormalLayer::onTouchBegan(Touch* touch, Event* event)
{
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	
	if (!isVisible())
		return false;

	touchBeginPos = touch->getLocation();
	return true;
}

bool CIapNormalLayer::onTouchEnd(Touch* touch, Event* event)
{
	auto touchEndPos = touch->getLocation();
	float delta = 5.0f;
	
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);

	if (abs(touchEndPos.x - touchBeginPos.x) > delta
			|| abs(touchEndPos.y - touchEndPos.y) > delta)
		return false;

	auto *iapLayer = dynamic_cast<CIapLayer *>(getParent());
	auto *popLayer = iapLayer->getPopLayer();
	
	popLayer->hide();
}

/********************* CIapDevelopLayer *********************/

CIapDevelopLayer::CIapDevelopLayer()
	: labelMcc(nullptr), labelMccClick(nullptr), labelMnc(nullptr), labelMncClick(nullptr), 
	  labelItemgroupID(nullptr), textItemgroupIDClick(nullptr), 
	  labelItemtypecode(nullptr), labelItemtypecodeClick(nullptr), 
	  buttonGetItemList(nullptr), buttonGetPurchased(nullptr)
{
}

CIapDevelopLayer::~CIapDevelopLayer()
{
	if (labelMcc)
		removeChild(labelMcc);
	if (labelMccClick)
		removeChild(labelMccClick);
	if (labelMnc)
		removeChild(labelMnc);
	if (labelMncClick)
		removeChild(labelMncClick);
	if (labelItemgroupID)
		removeChild(labelItemgroupID);
	if (textItemgroupIDClick)
		removeChild(textItemgroupIDClick);
	if (labelItemtypecode)
		removeChild(labelItemtypecode);
	if (labelItemtypecodeClick)
		removeChild(labelItemtypecodeClick);
	if (buttonGetItemList)
		removeChild(buttonGetItemList);
	if (buttonGetPurchased)
		removeChild(buttonGetPurchased);
}

bool CIapDevelopLayer::init()
{
	if (!Layer::init())
		return false;
	
    labelMcc = Label::createWithTTF("MCC", "fonts/arial.ttf", 48);
	labelMccClick = Label::createWithTTF("click here", "fonts/arial.ttf", 30);
	
	labelMnc = Label::createWithTTF("MNC", "fonts/arial.ttf", 48);
	labelMncClick = Label::createWithTTF("click here", "fonts/arial.ttf", 30);
	
    labelItemgroupID = Label::createWithTTF("Item Group ID", "fonts/arial.ttf", 48);
	textItemgroupIDClick = TextField::create("click here", "fonts/arial.ttf", 30);
	
	labelItemtypecode = Label::createWithTTF("Item Type Code", "fonts/arial.ttf", 48);
	labelItemtypecodeClick = Label::createWithTTF("click here", "fonts/arial.ttf", 30);
	
	buttonGetItemList = Button::create("image/button_normal.png", "image/button_active.png");
	buttonGetPurchased = Button::create("image/button_normal.png", "image/button_active.png");

	if (labelMcc == nullptr || labelMccClick == nullptr || labelMnc == nullptr || labelMncClick == nullptr
			|| labelItemgroupID == nullptr || textItemgroupIDClick == nullptr 
			|| labelItemtypecode == nullptr || labelItemtypecodeClick == nullptr
			|| buttonGetItemList == nullptr || buttonGetPurchased == nullptr)
		return false;

	addChild(labelMcc);
	addChild(labelMccClick);
	addChild(labelMnc);
	addChild(labelMncClick);
	addChild(labelItemgroupID);
	addChild(textItemgroupIDClick);
	addChild(labelItemtypecode);
	addChild(labelItemtypecodeClick);
	addChild(buttonGetItemList);
	addChild(buttonGetPurchased);

	layout();

	// listener
	auto listener = EventListenerTouchOneByOne::create();
	listener->onTouchBegan = CC_CALLBACK_2(CIapDevelopLayer::onTouchBegan, this);
	listener->onTouchEnded = CC_CALLBACK_2(CIapDevelopLayer::onTouchEnd, this);
	Director::getInstance()->getEventDispatcher()->addEventListenerWithSceneGraphPriority(listener, this);
	
	buttonGetItemList->addClickEventListener([=](Ref* sender) {
		TIAPDeveloperInfo pDevInfo;
		ProtocolIAP *protoIAP = (dynamic_cast<CIapLayer *>(getParent()))->getProtoIAP();
		CIapPopLayer *popLayer = (dynamic_cast<CIapLayer *>(getParent()))->getPopLayer();
		
		dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
		
		pDevInfo["get item list"] = "get item list";
		getIapDeveloperInfo(pDevInfo);
		
		popLayer->showNotice("waiting ...");
		protoIAP->configDeveloperInfo(pDevInfo);
	});

	buttonGetPurchased->addClickEventListener([=](Ref* sender) {
		TIAPDeveloperInfo pDevInfo;
		ProtocolIAP *protoIAP = (dynamic_cast<CIapLayer *>(getParent()))->getProtoIAP();
		CIapPopLayer *popLayer = (dynamic_cast<CIapLayer *>(getParent()))->getPopLayer();
		
		dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
		
		pDevInfo["get purchased list"] = "get purchased list";
		getIapDeveloperInfo(pDevInfo);
		
		popLayer->showNotice("waiting ...");
		protoIAP->configDeveloperInfo(pDevInfo);
	});
	
	return true;
}

void CIapDevelopLayer::layout()
{
	float posX;
	Vec2  pos;
	
	const float HD_HEAD = 16.0f;
	const float HD_GROUP_IN = 16.0f;
	const float HD_GROUP_OUT = 64.0f;

	auto visibleSize = Director::getInstance()->getVisibleSize();

	// MCC [click here]  MNC [click here]
	posX = HD_HEAD + labelMcc->getContentSize().width / 2;
	pos.set(posX, visibleSize.height * 0.7);
	labelMcc->setPosition(pos);
	labelMcc->setColor(Color3B::RED);

	posX += labelMcc->getContentSize().width + labelMccClick->getContentSize().width + HD_GROUP_IN;
	pos.set(posX, visibleSize.height * 0.7);
	labelMccClick->setPosition(pos);

	posX += labelMccClick->getContentSize().width + labelMnc->getContentSize().width + HD_GROUP_OUT;
	pos.set(posX, visibleSize.height * 0.7);
	labelMnc->setPosition(pos);
	labelMnc->setColor(Color3B::RED);
	
	posX += labelMnc->getContentSize().width + labelMncClick->getContentSize().width + HD_GROUP_IN;
	pos.set(posX, visibleSize.height * 0.7);
	labelMncClick->setPosition(pos);

	// Item Group ID [click here]
	posX = HD_HEAD + labelItemgroupID->getContentSize().width / 2;
	pos.set(posX, visibleSize.height * 0.5);
	labelItemgroupID->setPosition(pos);
	labelItemgroupID->setColor(Color3B::RED);

	posX += (labelItemgroupID->getContentSize().width + textItemgroupIDClick->getContentSize().width) + HD_GROUP_IN;
	pos.set(posX, visibleSize.height * 0.5);
	textItemgroupIDClick->setPosition(pos);

	// Item Type Code [click here]
	posX = HD_HEAD + labelItemtypecode->getContentSize().width / 2;
	pos.set(posX, visibleSize.height * 0.3);
	labelItemtypecode->setPosition(pos);
	labelItemtypecode->setColor(Color3B::RED);

	posX += (labelItemtypecode->getContentSize().width + labelItemtypecodeClick->getContentSize().width) + HD_GROUP_IN;
	pos.set(posX, visibleSize.height * 0.3);
	labelItemtypecodeClick->setPosition(pos);

	// get_item_list get_purchased
	pos.set(HD_HEAD + buttonGetItemList->getContentSize().width, visibleSize.height * 0.1);
	buttonGetItemList->setScale(2);
	buttonGetItemList->setTitleText("get_item_list");
	buttonGetItemList->setTitleFontSize(24);
	buttonGetItemList->setPosition(pos);
	
	pos.set(visibleSize.width - buttonGetPurchased->getContentSize().width, visibleSize.height * 0.1);
	buttonGetPurchased->setScale(2);
	buttonGetPurchased->setTitleText("get_purchased");
	buttonGetPurchased->setTitleFontSize(24);
	buttonGetPurchased->setPosition(pos);
}

void CIapDevelopLayer::getIapDeveloperInfo(TIAPDeveloperInfo &info)
{
	if (getMccClickText() == "click here")
		setMccClickText("404");
	if (getMncClickText() == "click here")
		setMncClickText("01");
	if (getItemgroupIDClickText() == "")  // not "click here" !!
		setItemgroupIDClickText("100000070614");
	if (getItemtypecodeClickText() == "click here")
		setItemtypecodeClickText("10");
	
	info["mode"] = "1";
	info["TizenAppKey"] = "TizenAppKey";
	info["language_cd"] = "ENG";
	info["start_date"] = "2014-01-01";
	info["end_date"] = "2020-12-31";
	info["start_number"] = "1";
	info["end_number"] = "200";

	info["mcc"] = getMccClickText();
	info["mnc"] = getMncClickText();
	info["item_group_id"] = getItemgroupIDClickText();
	info["item_type_cd"] = getItemtypecodeClickText();
	
	info["item_id"] = "000000581522";
	info["item_name"] = "item1";
}

bool CIapDevelopLayer::onTouchBegan(Touch* touch, Event* event)
{
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	
	if (!isVisible())
		return false;

	touchBeginPos = touch->getLocation();
	return true;
}

bool CIapDevelopLayer::onTouchEnd(Touch* touch, Event* event)
{
	auto touchEndPos = touch->getLocation();
	float delta = 5.0f;
	
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);

	if (abs(touchEndPos.x - touchBeginPos.x) > delta
			|| abs(touchEndPos.y - touchEndPos.y) > delta)
		return false;

	auto *iapLayer = dynamic_cast<CIapLayer *>(getParent());
	auto *popLayer = iapLayer->getPopLayer();
	
	popLayer->hide();

	if (labelMccClick->getBoundingBox().containsPoint(touchEndPos) 
		|| labelMncClick->getBoundingBox().containsPoint(touchEndPos))
	{
		TIAPDeveloperInfo pDevInfo;
		CIapPopLayer *popLayer = (dynamic_cast<CIapLayer *>(getParent()))->getPopLayer();
		
		dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
		popLayer->showNotice("waiting ...");
		
		pDevInfo["get country list"] = "get country list";
		iapLayer->getProtoIAP()->configDeveloperInfo(pDevInfo);
	}
	else if (labelItemtypecodeClick->getBoundingBox().containsPoint(touchEndPos))
	{
		// 1 touch, onTouchEnd() called 3 times !!
		if (!popLayer->isVisible()) {
			popLayer->show(CIapLayer::ItemTypeCodeClickPopType);
		}
	}
	
	return true;
}

/********************* CIapPopLayer *********************/

CIapPopLayer::CIapPopLayer()
	: scrollView(nullptr), labelNotice(nullptr)
{
}

CIapPopLayer::~CIapPopLayer()
{
	if (scrollView != nullptr) {
		scrollView->removeAllChildren();
		removeChild(scrollView);
	}

	if (labelNotice != nullptr)
		removeChild(labelNotice);
}

bool CIapPopLayer::init()
{
	if (!Layer::init())
		return false;

	scrollView = ScrollView::create();
	if (scrollView == nullptr)
		return false;

	addChild(scrollView);

	Size winSize = Director::getInstance()->getVisibleSize();
	Vec2 origin = Director::getInstance()->getVisibleOrigin();
	
	scrollView->setAnchorPoint(Vec2(0.5,0.5));
	scrollView->setContentSize(winSize);
	scrollView->setPosition(Vec2(origin.x + winSize.width/2, origin.y));
	scrollView->setBackGroundColor(Color3B::BLUE);
	scrollView->setBackGroundColorType(Layout::BackGroundColorType::SOLID);
	scrollView->setBackGroundColorOpacity(200);
	
	return true;
}

void CIapPopLayer::show(CIapLayer::PopLayerType type)
{
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	
	switch (type)
	{
	case CIapLayer::ItemTypeCodeClickPopType:
		showRetItemTypeCode();
		break;
	default:
		break;
	}
	
	setVisible(true);
}

void CIapPopLayer::show(CIapLayer::PopLayerType type, TProductList &info, IAPProductRequest ret)
{
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	
	switch (type)
	{
	case CIapLayer::MccMncClickPopType:
		showRetMccMnc(info, ret);
		break;
	case CIapLayer::GetItemListClickPopType:
		showRetGetItemList(info, ret);
		break;
	case CIapLayer::GetPurchasedClickPopType:
		showRetGetPurchased(info, ret);
		break;
	default:
		break;
	}
	
	setVisible(true);
}

void CIapPopLayer::show(CIapLayer::PopLayerType type, TProductInfo &info, PayResultCode ret, const char* msg)
{
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	
	switch (type)
	{
	case CIapLayer::PayClickType:
		showRetPay(info, ret, msg);
		break;
	default:
		break;
	}
	
	setVisible(true);
}

void CIapPopLayer::hide()
{
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	
	scrollView->removeAllChildren();
	if (labelNotice != nullptr) {
		removeChild(labelNotice);
		labelNotice = nullptr;
	}
	
	setVisible(false);
}

void CIapPopLayer::showRetMccMnc(TProductList &info, IAPProductRequest ret)
{
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	
	float innerWidth = scrollView->getContentSize().width;
	float innerHeight = scrollView->getContentSize().height +120;
	
	scrollView->setInnerContainerSize(Size(innerWidth, innerHeight));
	
#ifdef IAP_DEBUG
	for (int i = 0; i < 3; i ++)
	{
		char nameBuf[256];
		sprintf(nameBuf, "Country %d", i);
		auto label = Label::createWithSystemFont(string(nameBuf), string("Default font"), 50.0f);
		float y = scrollView->getInnerContainerSize().height - label->getContentSize().height*(i*2+1);
		label->setPosition(Vec2(innerWidth/2, y));
		label->setColor(Color3B::RED);
		scrollView->addChild(label);

		Button* selectButton = Button::create("image/button_normal.png", "image/button_active.png");
		selectButton->setTitleText("Select");
		selectButton->setContentSize(Size(300.0f, selectButton->getVirtualRendererSize().height));
		selectButton->setPosition(Vec2(innerWidth-200, y));
		selectButton->setTag(i);
		scrollView->addChild(selectButton);
		selectButton->addClickEventListener([=](Ref* sender){
			char nameBuf[256];
			auto iapLayer = dynamic_cast<CIapLayer *>(getParent());
			this->hide();
			sprintf(nameBuf, "mcc-%d", i);
			iapLayer->getDevelopLayer()->setMccClickText(string(nameBuf));
			sprintf(nameBuf, "mnc-%d", i);
			iapLayer->getDevelopLayer()->setMncClickText(string(nameBuf));
		});
	}
#else
	for (int i = 2; i < info.size(); i ++)
	{
		TProductInfo &item = info[i];
    	TProductInfo::iterator itr = item.find("mcc");
		if(item.end()==itr)
			continue;
		
		struct {
			string mcc;
			string mnc;
		} MccMnc = {
			(item.find("mcc"))->second, 
			/*(item.find("mnc"))->second*/""
		};
		auto label = Label::createWithSystemFont((item.find("name"))->second, string("Default font"), 50.0f);
		float y = scrollView->getInnerContainerSize().height - label->getContentSize().height*((i-2)*2+1);
		label->setPosition(Vec2(innerWidth/2, y));
		label->setColor(Color3B::RED);
		scrollView->addChild(label);
		
		dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);

		Button* selectButton = Button::create("image/button_normal.png", "image/button_active.png");
		selectButton->setTitleText("Select");
		selectButton->setContentSize(Size(300.0f, selectButton->getVirtualRendererSize().height));
		selectButton->setPosition(Vec2(innerWidth-200, y));
		selectButton->setUserData((void *)&MccMnc);
		scrollView->addChild(selectButton);
		selectButton->addClickEventListener([=](Ref* sender){
			struct tmp {
				string mcc;
				string mnc;
			} *MccMnc = (struct tmp*)getUserData();
			auto iapLayer = dynamic_cast<CIapLayer *>(getParent());
			this->hide();
			iapLayer->getDevelopLayer()->setMccClickText(/*MccMnc->mcc*/"404");
			iapLayer->getDevelopLayer()->setMncClickText(/*MccMnc->mnc*/"01");
		});
	}
#endif
}

void CIapPopLayer::showRetGetItemList(TProductList &info, IAPProductRequest ret)
{
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	
	float innerWidth = scrollView->getContentSize().width;
	float innerHeight = scrollView->getContentSize().height +120;
	
	scrollView->setInnerContainerSize(Size(innerWidth, innerHeight));
	
#ifdef IAP_DEBUG
	for(int i = 0; i < 3; i ++)
	{
		Sprite* icon = Sprite::create("weapon.png");
		float y = scrollView->getInnerContainerSize().height - icon->getContentSize().height*(i*2+1);
		icon->setPosition(Vec2(innerWidth/4, y));
		icon->setScale(1.5f, 1.5f);
		scrollView->addChild(icon);

		char nameBuf[256];
		sprintf(nameBuf, "Item %d", i);
		auto label = Label::createWithSystemFont(string(nameBuf), string("Default font"), 50.0f);
		label->setPosition(Vec2(innerWidth/2, y));
		label->setColor( Color3B::RED );
		scrollView->addChild(label);

		Button* buyButton = Button::create("tizenpay.png", "tizenpay2.png");
		buyButton->setTitleText("Buy");
		buyButton->setContentSize(Size(300.0f, buyButton->getVirtualRendererSize().height));
		buyButton->setPosition(Vec2(innerWidth-200, y));
		scrollView->addChild(buyButton);
		buyButton->addClickEventListener([=](Ref* sender) {
			TProductInfo pInfo;
			auto protoIAP = (dynamic_cast<CIapLayer *>(getParent()))->getProtoIAP();
			
			dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
			
			pInfo["TizenAppKey"] = "TizenAppKey";
			pInfo["item_name"] = "Item 1";
			pInfo["item_group_id"] = "100000000012";
			pInfo["item_id"] = "000000000001";
			pInfo["item_type_cd"] = "10";
			pInfo["language_cd"] = "ENG";
			pInfo["start_date"] = "2014-01-01";
			pInfo["end_date"] = "2020-12-31";
			pInfo["mode"] = "0";
			
			protoIAP->payForProduct(pInfo);
		});
	}
#else
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d: %d +++++", __FUNCTION__, __LINE__, info.size());
	for (int i = 2; i < info.size(); i ++)
	{
		//insert some items into the result view.
		TProductInfo &item = info[i];
    	TProductInfo::iterator itr = item.find("item_name");
		if(item.end()==itr)
			continue;

		std::string itemName = itr->second;
		//Sprite* icon = Sprite::create(item["item_image_path"]);
		Sprite* icon = Sprite::create("weapon.png");
		if(!icon)
			continue;

		float y = scrollView->getInnerContainerSize().height - icon->getContentSize().height*((i-2)*2+1);
		dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d: %f, %s +++++", __FUNCTION__, __LINE__, y, itemName.c_str());
		icon->setPosition(Vec2(innerWidth/4, y));
		icon->setScale(1.5f, 1.5f);
		scrollView->addChild(icon);

		auto label = Label::createWithSystemFont(itemName, std::string("Default font"), 50.0f);
		label->setPosition(Vec2(innerWidth/2, y));
		label->setColor( Color3B::RED );
		scrollView->addChild(label);

		Button* buyButton = Button::create("tizenpay.png", "tizenpay2.png");
		buyButton->setTitleText("Buy");
		buyButton->setContentSize(Size(300.0f, buyButton->getVirtualRendererSize().height));
		buyButton->setPosition(Vec2(innerWidth-200, y));
		scrollView->addChild(buyButton);
		buyButton->addClickEventListener([=](Ref* sender) {
			TProductInfo pInfo;
			auto protoIAP = (dynamic_cast<CIapLayer *>(getParent()))->getProtoIAP();

			dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);

			pInfo["TizenAppKey"] = "TizenAppKey";
			pInfo["item_name"] = "Item 1";
			pInfo["item_group_id"] = "100000000012";
			pInfo["item_id"] = "000000000001";
			pInfo["item_type_cd"] = "10";
			pInfo["language_cd"] = "ENG";
			pInfo["start_date"] = "2014-01-01";
			pInfo["end_date"] = "2020-12-31";
			pInfo["mode"] = "0";

			protoIAP->payForProduct(pInfo);
		});
	}
#endif
}

void CIapPopLayer::showRetGetPurchased(TProductList &info, IAPProductRequest ret)
{
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	
	float innerWidth = scrollView->getContentSize().width;
	float innerHeight = scrollView->getContentSize().height +120;
	
	scrollView->setInnerContainerSize(Size(innerWidth, innerHeight));
	
#ifdef IAP_DEBUG
	for(int i = 0; i < 3; i++)
	{
		Sprite* icon = Sprite::create("weapon.png");
		float y = scrollView->getInnerContainerSize().height - icon->getContentSize().height*(i*2+1);
		icon->setPosition(Vec2(innerWidth/4, y));
		icon->setScale(1.5f, 1.5f);
		scrollView->addChild(icon);

		char nameBuf[256];
		sprintf(nameBuf, "Item %d", i);
		auto label = Label::createWithSystemFont(string(nameBuf), string("Default font"), 50.0f);
		label->setPosition(Vec2(innerWidth/2, y));
		label->setColor( Color3B::RED );
		scrollView->addChild(label);
	}
#else
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d: %d +++++", __FUNCTION__, __LINE__, info.size());
	for (int i = 1; i < info.size(); i ++)
	{
		//insert some items into the result view.
		TProductInfo &item = info[i];
    	TProductInfo::iterator itr = item.find("item_name");
		if(item.end()==itr)
			continue;

		std::string itemName = itr->second;
		//Sprite* icon = Sprite::create(item["item_image_path"]);
		Sprite* icon = Sprite::create("weapon.png");
		if(!icon)
			continue;

		float y = scrollView->getInnerContainerSize().height - icon->getContentSize().height*((i-1)*2+1);
		dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d: %f, %s +++++", __FUNCTION__, __LINE__, y, itemName.c_str());
		icon->setPosition(Vec2(innerWidth/4, y));
		icon->setScale(1.5f, 1.5f);
		scrollView->addChild(icon);

		auto label = Label::createWithSystemFont(itemName, std::string("Default font"), 50.0f);
		label->setPosition(Vec2(innerWidth/2, y));
		label->setColor( Color3B::RED );
		scrollView->addChild(label);
	}
#endif
}

void CIapPopLayer::showRetPay(TProductInfo &info, PayResultCode ret, const char* msg)
{
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	
#ifdef IAP_DEBUG
	showNotice(string("Pay failed !"));
#else
	switch(ret)
	{
	case kPaySuccess:
		showNotice(string("Pay success !"));
		break;
	case kPayFail:
		showNotice(string("Pay failed !"));
		break;
	case kPayCancel:
		showNotice(string("Pay canceled !"));
		break;
	case kPayTimeOut:
		showNotice(string("Request Time Out !"));
		break;
	default:
		break;
	}
#endif
}

void CIapPopLayer::showRetItemTypeCode()
{
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	
	float innerWidth = scrollView->getContentSize().width;
	float innerHeight = scrollView->getContentSize().height +120;

	scrollView->setInnerContainerSize(Size(innerWidth, innerHeight));
	
	auto label = Label::createWithSystemFont(string("Consumable"), string("Default font"), 50.0f);
	float y = scrollView->getInnerContainerSize().height - label->getContentSize().height;
	label->setPosition(Vec2(innerWidth/2, y));
	label->setColor( Color3B::RED );
	scrollView->addChild(label);

	Button* button = Button::create("image/button_normal.png", "image/button_active.png");
	button->setTitleText("Select");
	button->setContentSize(Size(300.0f, button->getVirtualRendererSize().height));
	button->setPosition(Vec2(innerWidth-200, y));
	scrollView->addChild(button);
	button->addClickEventListener([=](Ref* sender){
		auto iapLayer = dynamic_cast<CIapLayer *>(getParent());
		this->hide();
		iapLayer->getDevelopLayer()->setItemtypecodeClickText("00");
	});
	
	label = Label::createWithSystemFont(string("Non-consumable"), string("Default font"), 50.0f);
	y = scrollView->getInnerContainerSize().height - label->getContentSize().height*3;
	label->setPosition(Vec2(innerWidth/2, y));
	label->setColor( Color3B::RED );
	scrollView->addChild(label);

	button = Button::create("image/button_normal.png", "image/button_active.png");
	button->setTitleText("Select");
	button->setContentSize(Size(300.0f, button->getVirtualRendererSize().height));
	button->setPosition(Vec2(innerWidth-200, y));
	scrollView->addChild(button);
	button->addClickEventListener([=](Ref* sender){
		auto iapLayer = dynamic_cast<CIapLayer *>(getParent());
		this->hide();
		iapLayer->getDevelopLayer()->setItemtypecodeClickText("01");
	});
	
	label = Label::createWithSystemFont(string("Subscription"), string("Default font"), 50.0f);
	y = scrollView->getInnerContainerSize().height - label->getContentSize().height*5;
	label->setPosition(Vec2(innerWidth/2, y));
	label->setColor( Color3B::RED );
	scrollView->addChild(label);

	button = Button::create("image/button_normal.png", "image/button_active.png");
	button->setTitleText("Select");
	button->setContentSize(Size(300.0f, button->getVirtualRendererSize().height));
	button->setPosition(Vec2(innerWidth-200, y));
	scrollView->addChild(button);
	button->addClickEventListener([=](Ref* sender){
		auto iapLayer = dynamic_cast<CIapLayer *>(getParent());
		this->hide();
		iapLayer->getDevelopLayer()->setItemtypecodeClickText("10");
	});
	
	label = Label::createWithSystemFont(string("All"), string("Default font"), 50.0f);
	y = scrollView->getInnerContainerSize().height - label->getContentSize().height*7;
	label->setPosition(Vec2(innerWidth/2, y));
	label->setColor( Color3B::RED );
	scrollView->addChild(label);

	button = Button::create("image/button_normal.png", "image/button_active.png");
	button->setTitleText("Select");
	button->setContentSize(Size(300.0f, button->getVirtualRendererSize().height));
	button->setPosition(Vec2(innerWidth-200, y));
	scrollView->addChild(button);
	button->addClickEventListener([=](Ref* sender){
		auto iapLayer = dynamic_cast<CIapLayer *>(getParent());
		this->hide();
		iapLayer->getDevelopLayer()->setItemtypecodeClickText("11");
	});
}

void CIapPopLayer::showLoading()
{
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);
	
#ifdef IAP_DEBUG
#else
	// create view by info
#endif
}

void CIapPopLayer::showNotice(string text)
{
	dlog_print(DLOG_ERROR, "TIZEN_IAP", "%s(), %d +++++", __FUNCTION__, __LINE__);

	if (labelNotice != nullptr)
		labelNotice->setString(text);
	else
	{
		Size winSize = Director::getInstance()->getVisibleSize();
		Vec2 origin = Director::getInstance()->getVisibleOrigin();
		labelNotice = Label::createWithTTF(text, "fonts/arial.ttf", 48);
		
		labelNotice->setAnchorPoint(Vec2(0.5,0.0));
		labelNotice->setContentSize(Size(100, 100));
		labelNotice->setColor(Color3B::RED);
		labelNotice->setPosition(Vec2(origin.x + winSize.width/2, origin.y + winSize.height/2));
		
		addChild(labelNotice);
	}

	setVisible(true);
}



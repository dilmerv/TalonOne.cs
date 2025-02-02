# TalonOne.Model.NewCampaignTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The campaign template name. | 
**Description** | **string** | Customer-facing text that explains the objective of the template. | 
**Instructions** | **string** | Customer-facing text that explains how to use the template. For example, you can use this property to explain the available attributes of this template, and how they can be modified when a user uses this template to create a new campaign. | 
**CampaignAttributes** | [**Object**](.md) | The Campaign Attributes that Campaigns created from this template will have by default. | [optional] 
**CouponAttributes** | [**Object**](.md) | The Campaign Attributes that Coupons created from this template will have by default. | [optional] 
**State** | **string** | Only Campaign Templates in &#39;available&#39; state may be used to create Campaigns. | 
**Tags** | **List&lt;string&gt;** | A list of tags for the campaign template. | [optional] 
**Features** | **List&lt;string&gt;** | A list of features for the campaign template. | [optional] 
**CouponSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**ReferralSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**Limits** | [**List&lt;TemplateLimitConfig&gt;**](TemplateLimitConfig.md) | The set of limits that will operate for this campaign template | [optional] 
**TemplateParams** | [**List&lt;CampaignTemplateParams&gt;**](CampaignTemplateParams.md) | Template parameters are fields which can be used to replace values in a rule. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


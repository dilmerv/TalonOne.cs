# TalonOne.Model.ApplicationSession
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. The exact moment this entity was created. | 
**ApplicationId** | **int** | The ID of the application that owns this entity. | 
**ProfileId** | **int** | The globally unique Talon.One ID of the customer that created this entity. | [optional] 
**IntegrationId** | **string** | The integration ID for this entity sent to and used in the Talon.One system. | 
**Profileintegrationid** | **string** | Integration ID of the customer for the session. | [optional] 
**Coupon** | **string** | Any coupon code entered. | 
**Referral** | **string** | Any referral code entered. | 
**State** | **string** | Indicating if the customer session is in progress (&#x60;open&#x60;), &#x60;closed&#x60;, or &#x60;cancelled&#x60;. For more information about customer sessions, see [Customer sessions](/docs/dev/concepts/entities#customer-session-states) in the docs.  | 
**CartItems** | [**List&lt;CartItem&gt;**](CartItem.md) | Serialized JSON representation. | 
**Discounts** | **Dictionary&lt;string, decimal&gt;** | A map of labelled discount values, in the same currency as the session. | 
**Total** | **decimal** | The total sum of the session before any discounts applied. | 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this item | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


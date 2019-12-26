# TmApi.Model.KeywordsResponseKeywords
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Keyword** | **string** | Normalized keyword | [optional] 
**Negated** | **bool?** | Indicates negation in the semantics of the word and returns the boolean values | [optional] 
**PartOfSpeech** | **string** | Part of speech of the keyword | [optional] 
**Significance** | **decimal?** | How distinct a particular keyword is for the explored text. Significance is calculated on a scale of 0,00 to 100,00. The greater the significance, the greater the chance that the concepts in the investigated data revolve around such a word.  | [optional] 
**Support** | **int?** | The number of different records containing the keyword | [optional] 
**Frequency** | **int?** | The number of times the keyword appears in the data | [optional] 
**Positions** | [**List&lt;KeywordsResponsePositions&gt;**](KeywordsResponsePositions.md) | Keyword positions in text | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


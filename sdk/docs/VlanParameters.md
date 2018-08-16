# IO.Swagger.Model.VlanParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisableVlan** | **bool?** | Specifies whether to use the VIPs even when VLANs are configured on the Cluster. If configured, VLAN IP addresses are used by default. If VLANs are not configured, this flag is ignored. Set this flag to true to force using the partition VIPs when VLANs are configured on the Cluster. | [optional] 
**Vlan** | **int?** | Specifies the VLAN to use for mounting Cohesity&#39;s view on the remote host. If specified, Cohesity hostname or the IP address on this VLAN is used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.ServiceCatalog.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoptionassociation.html </remarks>
    public class TagOptionAssociationResourceProps : DeputyBase, ITagOptionAssociationResourceProps
    {
        /// <summary>``AWS::ServiceCatalog::TagOptionAssociation.ResourceId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoptionassociation.html#cfn-servicecatalog-tagoptionassociation-resourceid </remarks>
        [JsiiProperty("resourceId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object ResourceId
        {
            get;
            set;
        }

        /// <summary>``AWS::ServiceCatalog::TagOptionAssociation.TagOptionId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoptionassociation.html#cfn-servicecatalog-tagoptionassociation-tagoptionid </remarks>
        [JsiiProperty("tagOptionId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object TagOptionId
        {
            get;
            set;
        }
    }
}
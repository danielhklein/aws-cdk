using Amazon.CDK;
using Amazon.CDK.AWS.SES.cloudformation.ReceiptRuleResource;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.SES.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html </remarks>
    public class ReceiptRuleResourceProps : DeputyBase, IReceiptRuleResourceProps
    {
        /// <summary>``AWS::SES::ReceiptRule.Rule``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html#cfn-ses-receiptrule-rule </remarks>
        [JsiiProperty("rule", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-ses.cloudformation.ReceiptRuleResource.RuleProperty\"}]}}", true)]
        public object Rule
        {
            get;
            set;
        }

        /// <summary>``AWS::SES::ReceiptRule.RuleSetName``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html#cfn-ses-receiptrule-rulesetname </remarks>
        [JsiiProperty("ruleSetName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object RuleSetName
        {
            get;
            set;
        }

        /// <summary>``AWS::SES::ReceiptRule.After``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html#cfn-ses-receiptrule-after </remarks>
        [JsiiProperty("after", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object After
        {
            get;
            set;
        }
    }
}
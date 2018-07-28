using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.Inspector.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttarget.html </remarks>
    [JsiiInterface(typeof(IAssessmentTargetResourceProps), "@aws-cdk/aws-inspector.cloudformation.AssessmentTargetResourceProps")]
    public interface IAssessmentTargetResourceProps
    {
        /// <summary>``AWS::Inspector::AssessmentTarget.ResourceGroupArn``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttarget.html#cfn-inspector-assessmenttarget-resourcegrouparn </remarks>
        [JsiiProperty("resourceGroupArn", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object ResourceGroupArn
        {
            get;
            set;
        }

        /// <summary>``AWS::Inspector::AssessmentTarget.AssessmentTargetName``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttarget.html#cfn-inspector-assessmenttarget-assessmenttargetname </remarks>
        [JsiiProperty("assessmentTargetName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object AssessmentTargetName
        {
            get;
            set;
        }
    }
}
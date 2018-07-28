using Amazon.CDK;
using Amazon.CDK.AWS.EMR.cloudformation.StepResource;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.EMR.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html </remarks>
    public class StepResourceProps : DeputyBase, IStepResourceProps
    {
        /// <summary>``AWS::EMR::Step.ActionOnFailure``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-actiononfailure </remarks>
        [JsiiProperty("actionOnFailure", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object ActionOnFailure
        {
            get;
            set;
        }

        /// <summary>``AWS::EMR::Step.HadoopJarStep``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-hadoopjarstep </remarks>
        [JsiiProperty("hadoopJarStep", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-emr.cloudformation.StepResource.HadoopJarStepConfigProperty\"}]}}", true)]
        public object HadoopJarStep
        {
            get;
            set;
        }

        /// <summary>``AWS::EMR::Step.JobFlowId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-jobflowid </remarks>
        [JsiiProperty("jobFlowId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object JobFlowId
        {
            get;
            set;
        }

        /// <summary>``AWS::EMR::Step.Name``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-name </remarks>
        [JsiiProperty("stepName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object StepName
        {
            get;
            set;
        }
    }
}
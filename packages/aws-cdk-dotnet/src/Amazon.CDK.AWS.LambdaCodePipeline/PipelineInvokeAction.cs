using Amazon.CDK.AWS.CodePipeline;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.LambdaCodePipeline
{
    /// <summary>CodePipeline invoke Action that is provided by an AWS Lambda function.</summary>
    /// <remarks>see: https://docs.aws.amazon.com/codepipeline/latest/userguide/actions-invoke-lambda-function.html</remarks>
    [JsiiClass(typeof(PipelineInvokeAction), "@aws-cdk/aws-lambda-codepipeline.PipelineInvokeAction", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"@aws-cdk/aws-codepipeline.Stage\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"@aws-cdk/aws-lambda-codepipeline.PipelineInvokeActionProps\"}}]")]
    public class PipelineInvokeAction : Action
    {
        public PipelineInvokeAction(Stage parent, string name, IPipelineInvokeActionProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected PipelineInvokeAction(ByRefValue reference): base(reference)
        {
        }

        protected PipelineInvokeAction(DeputyProps props): base(props)
        {
        }

        /// <summary>Add an input artifact</summary>
        [JsiiMethod("addInputArtifact", "{\"fqn\":\"@aws-cdk/aws-lambda-codepipeline.PipelineInvokeAction\"}", "[{\"name\":\"artifact\",\"type\":{\"fqn\":\"@aws-cdk/aws-codepipeline.Artifact\"}}]")]
        public override PipelineInvokeAction AddInputArtifact(Artifact artifact)
        {
            return InvokeInstanceMethod<PipelineInvokeAction>(new object[]{artifact});
        }
    }
}
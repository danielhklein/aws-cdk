using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.Serverless.cloudformation.FunctionResource
{
    /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#kinesis </remarks>
    [JsiiInterface(typeof(IKinesisEventProperty), "@aws-cdk/aws-serverless.cloudformation.FunctionResource.KinesisEventProperty")]
    public interface IKinesisEventProperty
    {
        /// <summary>``FunctionResource.KinesisEventProperty.BatchSize``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#kinesis </remarks>
        [JsiiProperty("batchSize", "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object BatchSize
        {
            get;
            set;
        }

        /// <summary>``FunctionResource.KinesisEventProperty.StartingPosition``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#kinesis </remarks>
        [JsiiProperty("startingPosition", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object StartingPosition
        {
            get;
            set;
        }

        /// <summary>``FunctionResource.KinesisEventProperty.Stream``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#kinesis </remarks>
        [JsiiProperty("stream", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object Stream
        {
            get;
            set;
        }
    }
}
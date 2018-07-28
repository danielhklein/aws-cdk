using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.S3.cloudformation.BucketResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-storageclassanalysis.html </remarks>
    [JsiiInterface(typeof(IStorageClassAnalysisProperty), "@aws-cdk/aws-s3.cloudformation.BucketResource.StorageClassAnalysisProperty")]
    public interface IStorageClassAnalysisProperty
    {
        /// <summary>``BucketResource.StorageClassAnalysisProperty.DataExport``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-storageclassanalysis.html#cfn-s3-bucket-storageclassanalysis-dataexport </remarks>
        [JsiiProperty("dataExport", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-s3.cloudformation.BucketResource.DataExportProperty\"}]},\"optional\":true}")]
        object DataExport
        {
            get;
            set;
        }
    }
}
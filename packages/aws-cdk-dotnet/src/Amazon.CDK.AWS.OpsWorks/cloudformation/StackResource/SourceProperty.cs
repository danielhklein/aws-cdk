using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.OpsWorks.cloudformation.StackResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-source.html </remarks>
    public class SourceProperty : DeputyBase, Amazon.CDK.AWS.OpsWorks.cloudformation.StackResource.ISourceProperty
    {
        /// <summary>``StackResource.SourceProperty.Password``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-source.html#cfn-opsworks-custcookbooksource-password </remarks>
        [JsiiProperty("password", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object Password
        {
            get;
            set;
        }

        /// <summary>``StackResource.SourceProperty.Revision``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-source.html#cfn-opsworks-custcookbooksource-revision </remarks>
        [JsiiProperty("revision", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object Revision
        {
            get;
            set;
        }

        /// <summary>``StackResource.SourceProperty.SshKey``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-source.html#cfn-opsworks-custcookbooksource-sshkey </remarks>
        [JsiiProperty("sshKey", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object SshKey
        {
            get;
            set;
        }

        /// <summary>``StackResource.SourceProperty.Type``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-source.html#cfn-opsworks-custcookbooksource-type </remarks>
        [JsiiProperty("type", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object Type
        {
            get;
            set;
        }

        /// <summary>``StackResource.SourceProperty.Url``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-source.html#cfn-opsworks-custcookbooksource-url </remarks>
        [JsiiProperty("url", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object Url
        {
            get;
            set;
        }

        /// <summary>``StackResource.SourceProperty.Username``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-source.html#cfn-opsworks-custcookbooksource-username </remarks>
        [JsiiProperty("username", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object Username
        {
            get;
            set;
        }
    }
}
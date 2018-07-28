using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.EC2.cloudformation.LaunchTemplateResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-privateipadd.html </remarks>
    [JsiiInterface(typeof(IPrivateIpAddProperty), "@aws-cdk/aws-ec2.cloudformation.LaunchTemplateResource.PrivateIpAddProperty")]
    public interface IPrivateIpAddProperty
    {
        /// <summary>``LaunchTemplateResource.PrivateIpAddProperty.Primary``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-privateipadd.html#cfn-ec2-launchtemplate-privateipadd-primary </remarks>
        [JsiiProperty("primary", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object Primary
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.PrivateIpAddProperty.PrivateIpAddress``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-privateipadd.html#cfn-ec2-launchtemplate-privateipadd-privateipaddress </remarks>
        [JsiiProperty("privateIpAddress", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object PrivateIpAddress
        {
            get;
            set;
        }
    }
}
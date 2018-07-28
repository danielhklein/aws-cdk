using Amazon.CDK;
using Amazon.CDK.AWS.DirectoryService.cloudformation.MicrosoftADResource;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.DirectoryService.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html </remarks>
    public class MicrosoftADResourceProps : DeputyBase, IMicrosoftADResourceProps
    {
        /// <summary>``AWS::DirectoryService::MicrosoftAD.Name``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-name </remarks>
        [JsiiProperty("microsoftAdName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object MicrosoftAdName
        {
            get;
            set;
        }

        /// <summary>``AWS::DirectoryService::MicrosoftAD.Password``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-password </remarks>
        [JsiiProperty("password", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object Password
        {
            get;
            set;
        }

        /// <summary>``AWS::DirectoryService::MicrosoftAD.VpcSettings``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-vpcsettings </remarks>
        [JsiiProperty("vpcSettings", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-directoryservice.cloudformation.MicrosoftADResource.VpcSettingsProperty\"}]}}", true)]
        public object VpcSettings
        {
            get;
            set;
        }

        /// <summary>``AWS::DirectoryService::MicrosoftAD.CreateAlias``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-createalias </remarks>
        [JsiiProperty("createAlias", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object CreateAlias
        {
            get;
            set;
        }

        /// <summary>``AWS::DirectoryService::MicrosoftAD.Edition``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-edition </remarks>
        [JsiiProperty("edition", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object Edition
        {
            get;
            set;
        }

        /// <summary>``AWS::DirectoryService::MicrosoftAD.EnableSso``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-enablesso </remarks>
        [JsiiProperty("enableSso", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object EnableSso
        {
            get;
            set;
        }

        /// <summary>``AWS::DirectoryService::MicrosoftAD.ShortName``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-shortname </remarks>
        [JsiiProperty("shortName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object ShortName
        {
            get;
            set;
        }
    }
}
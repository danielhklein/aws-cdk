using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.EC2.cloudformation.LaunchTemplateResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html </remarks>
    [JsiiInterface(typeof(ILaunchTemplateDataProperty), "@aws-cdk/aws-ec2.cloudformation.LaunchTemplateResource.LaunchTemplateDataProperty")]
    public interface ILaunchTemplateDataProperty
    {
        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.BlockDeviceMappings``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-blockdevicemappings </remarks>
        [JsiiProperty("blockDeviceMappings", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-ec2.cloudformation.LaunchTemplateResource.BlockDeviceMappingProperty\"}]}}}}]},\"optional\":true}")]
        object BlockDeviceMappings
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.CreditSpecification``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-creditspecification </remarks>
        [JsiiProperty("creditSpecification", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-ec2.cloudformation.LaunchTemplateResource.CreditSpecificationProperty\"}]},\"optional\":true}")]
        object CreditSpecification
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.DisableApiTermination``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-disableapitermination </remarks>
        [JsiiProperty("disableApiTermination", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object DisableApiTermination
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.EbsOptimized``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-ebsoptimized </remarks>
        [JsiiProperty("ebsOptimized", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object EbsOptimized
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.ElasticGpuSpecifications``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-elasticgpuspecifications </remarks>
        [JsiiProperty("elasticGpuSpecifications", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-ec2.cloudformation.LaunchTemplateResource.ElasticGpuSpecificationProperty\"}]}}}}]},\"optional\":true}")]
        object ElasticGpuSpecifications
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.IamInstanceProfile``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-iaminstanceprofile </remarks>
        [JsiiProperty("iamInstanceProfile", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-ec2.cloudformation.LaunchTemplateResource.IamInstanceProfileProperty\"}]},\"optional\":true}")]
        object IamInstanceProfile
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.ImageId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-imageid </remarks>
        [JsiiProperty("imageId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object ImageId
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.InstanceInitiatedShutdownBehavior``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-instanceinitiatedshutdownbehavior </remarks>
        [JsiiProperty("instanceInitiatedShutdownBehavior", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object InstanceInitiatedShutdownBehavior
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.InstanceMarketOptions``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-instancemarketoptions </remarks>
        [JsiiProperty("instanceMarketOptions", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-ec2.cloudformation.LaunchTemplateResource.InstanceMarketOptionsProperty\"}]},\"optional\":true}")]
        object InstanceMarketOptions
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.InstanceType``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-instancetype </remarks>
        [JsiiProperty("instanceType", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object InstanceType
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.KernelId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-kernelid </remarks>
        [JsiiProperty("kernelId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object KernelId
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.KeyName``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-keyname </remarks>
        [JsiiProperty("keyName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object KeyName
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.Monitoring``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-monitoring </remarks>
        [JsiiProperty("monitoring", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-ec2.cloudformation.LaunchTemplateResource.MonitoringProperty\"}]},\"optional\":true}")]
        object Monitoring
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.NetworkInterfaces``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-networkinterfaces </remarks>
        [JsiiProperty("networkInterfaces", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-ec2.cloudformation.LaunchTemplateResource.NetworkInterfaceProperty\"}]}}}}]},\"optional\":true}")]
        object NetworkInterfaces
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.Placement``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-placement </remarks>
        [JsiiProperty("placement", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-ec2.cloudformation.LaunchTemplateResource.PlacementProperty\"}]},\"optional\":true}")]
        object Placement
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.RamDiskId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-ramdiskid </remarks>
        [JsiiProperty("ramDiskId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object RamDiskId
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.SecurityGroupIds``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-securitygroupids </remarks>
        [JsiiProperty("securityGroupIds", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}}}]},\"optional\":true}")]
        object SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.SecurityGroups``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-securitygroups </remarks>
        [JsiiProperty("securityGroups", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}}}]},\"optional\":true}")]
        object SecurityGroups
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.TagSpecifications``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-tagspecifications </remarks>
        [JsiiProperty("tagSpecifications", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-ec2.cloudformation.LaunchTemplateResource.TagSpecificationProperty\"}]}}}}]},\"optional\":true}")]
        object TagSpecifications
        {
            get;
            set;
        }

        /// <summary>``LaunchTemplateResource.LaunchTemplateDataProperty.UserData``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-userdata </remarks>
        [JsiiProperty("userData", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object UserData
        {
            get;
            set;
        }
    }
}
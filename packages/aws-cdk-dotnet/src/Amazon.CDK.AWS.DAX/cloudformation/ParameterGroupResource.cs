using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Amazon.CDK.AWS.DAX.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-parametergroup.html </remarks>
    [JsiiClass(typeof(ParameterGroupResource), "@aws-cdk/aws-dax.cloudformation.ParameterGroupResource", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"@aws-cdk/cdk.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"properties\",\"type\":{\"fqn\":\"@aws-cdk/aws-dax.cloudformation.ParameterGroupResourceProps\",\"optional\":true}}]")]
    public class ParameterGroupResource : Resource
    {
        public ParameterGroupResource(Construct parent, string name, IParameterGroupResourceProps properties): base(new DeputyProps(new object[]{parent, name, properties}))
        {
        }

        protected ParameterGroupResource(ByRefValue reference): base(reference)
        {
        }

        protected ParameterGroupResource(DeputyProps props): base(props)
        {
        }

        /// <summary>The CloudFormation resource type name for this resource class.</summary>
        [JsiiProperty("resourceTypeName", "{\"primitive\":\"string\"}")]
        public static string ResourceTypeName
        {
            get;
        }

        = GetStaticProperty<string>(typeof(ParameterGroupResource));
        [JsiiMethod("renderProperties", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}}}", "[]")]
        protected override IDictionary<string, object> RenderProperties()
        {
            return InvokeInstanceMethod<IDictionary<string, object>>(new object[]{});
        }
    }
}
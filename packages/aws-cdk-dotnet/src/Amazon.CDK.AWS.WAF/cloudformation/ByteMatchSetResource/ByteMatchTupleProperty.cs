using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.WAF.cloudformation.ByteMatchSetResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples.html </remarks>
    public class ByteMatchTupleProperty : DeputyBase, IByteMatchTupleProperty
    {
        /// <summary>``ByteMatchSetResource.ByteMatchTupleProperty.FieldToMatch``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples.html#cfn-waf-bytematchset-bytematchtuples-fieldtomatch </remarks>
        [JsiiProperty("fieldToMatch", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-waf.cloudformation.ByteMatchSetResource.FieldToMatchProperty\"}]}}", true)]
        public object FieldToMatch
        {
            get;
            set;
        }

        /// <summary>``ByteMatchSetResource.ByteMatchTupleProperty.PositionalConstraint``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples.html#cfn-waf-bytematchset-bytematchtuples-positionalconstraint </remarks>
        [JsiiProperty("positionalConstraint", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object PositionalConstraint
        {
            get;
            set;
        }

        /// <summary>``ByteMatchSetResource.ByteMatchTupleProperty.TargetString``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples.html#cfn-waf-bytematchset-bytematchtuples-targetstring </remarks>
        [JsiiProperty("targetString", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object TargetString
        {
            get;
            set;
        }

        /// <summary>``ByteMatchSetResource.ByteMatchTupleProperty.TargetStringBase64``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples.html#cfn-waf-bytematchset-bytematchtuples-targetstringbase64 </remarks>
        [JsiiProperty("targetStringBase64", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object TargetStringBase64
        {
            get;
            set;
        }

        /// <summary>``ByteMatchSetResource.ByteMatchTupleProperty.TextTransformation``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples.html#cfn-waf-bytematchset-bytematchtuples-texttransformation </remarks>
        [JsiiProperty("textTransformation", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object TextTransformation
        {
            get;
            set;
        }
    }
}
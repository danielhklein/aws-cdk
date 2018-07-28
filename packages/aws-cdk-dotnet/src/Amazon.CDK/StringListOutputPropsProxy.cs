using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK
{
    /// <summary>Properties for ListOutput</summary>
    [JsiiInterfaceProxy(typeof(IStringListOutputProps), "@aws-cdk/cdk.StringListOutputProps")]
    internal class StringListOutputPropsProxy : DeputyBase, IStringListOutputProps
    {
        private StringListOutputPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// A String type that describes the output value.
        /// The description can be a maximum of 4 K in length.
        /// </summary>
        [JsiiProperty("description", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>();
        }

        /// <summary>The list of primitives to export</summary>
        [JsiiProperty("values", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"any\"}}}")]
        public virtual object[] Values
        {
            get => GetInstanceProperty<object[]>();
        }

        /// <summary>The separator to use to separate stringified values</summary>
        /// <remarks>default: ","</remarks>
        [JsiiProperty("separator", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Separator
        {
            get => GetInstanceProperty<string>();
        }

        /// <summary>
        /// The name used to export the value of this output across stacks. To import
        /// the value from another stack, use `FnImportValue(export)`. You can create
        /// an import value token by calling `output.makeImportValue()`.
        /// </summary>
        /// <remarks>
        /// default: The default behavior is to automatically allocate an export name
        /// for outputs based on the stack name and the output's logical ID. To
        /// create an output without an export, set `disableExport: true`.
        /// </remarks>
        [JsiiProperty("export", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Export
        {
            get => GetInstanceProperty<string>();
        }

        /// <summary>Disables the automatic allocation of an export name for this output.</summary>
        /// <remarks>
        /// default: false, which means that an export name is either explicitly
        /// specified or allocated based on the output's logical ID and stack name.
        /// </remarks>
        [JsiiProperty("disableExport", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? DisableExport
        {
            get => GetInstanceProperty<bool? >();
        }

        /// <summary>
        /// A condition from the "Conditions" section to associate with this output
        /// value. If the condition evaluates to `false`, this output value will not
        /// be included in the stack.
        /// </summary>
        [JsiiProperty("condition", "{\"fqn\":\"@aws-cdk/cdk.Condition\",\"optional\":true}")]
        public virtual Condition Condition
        {
            get => GetInstanceProperty<Condition>();
        }
    }
}
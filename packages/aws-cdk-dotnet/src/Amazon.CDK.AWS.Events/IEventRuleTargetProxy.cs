using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.Events
{
    /// <summary>An abstract target for EventRules.</summary>
    [JsiiInterfaceProxy(typeof(IIEventRuleTarget), "@aws-cdk/aws-events.IEventRuleTarget")]
    internal class IEventRuleTargetProxy : DeputyBase, IIEventRuleTarget
    {
        private IEventRuleTargetProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// Returns the rule target specification.
        /// NOTE: Do not use the various `inputXxx` options. They can be set in a call to `addTarget`.
        /// </summary>
        [JsiiProperty("eventRuleTarget", "{\"fqn\":\"@aws-cdk/aws-events.EventRuleTargetProps\"}")]
        public virtual IEventRuleTargetProps EventRuleTarget
        {
            get => GetInstanceProperty<IEventRuleTargetProps>();
        }
    }
}
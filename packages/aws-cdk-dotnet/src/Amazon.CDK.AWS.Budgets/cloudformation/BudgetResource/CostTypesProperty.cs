using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.Budgets.cloudformation.BudgetResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html </remarks>
    public class CostTypesProperty : DeputyBase, ICostTypesProperty
    {
        /// <summary>``BudgetResource.CostTypesProperty.IncludeCredit``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includecredit </remarks>
        [JsiiProperty("includeCredit", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object IncludeCredit
        {
            get;
            set;
        }

        /// <summary>``BudgetResource.CostTypesProperty.IncludeDiscount``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includediscount </remarks>
        [JsiiProperty("includeDiscount", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object IncludeDiscount
        {
            get;
            set;
        }

        /// <summary>``BudgetResource.CostTypesProperty.IncludeOtherSubscription``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includeothersubscription </remarks>
        [JsiiProperty("includeOtherSubscription", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object IncludeOtherSubscription
        {
            get;
            set;
        }

        /// <summary>``BudgetResource.CostTypesProperty.IncludeRecurring``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includerecurring </remarks>
        [JsiiProperty("includeRecurring", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object IncludeRecurring
        {
            get;
            set;
        }

        /// <summary>``BudgetResource.CostTypesProperty.IncludeRefund``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includerefund </remarks>
        [JsiiProperty("includeRefund", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object IncludeRefund
        {
            get;
            set;
        }

        /// <summary>``BudgetResource.CostTypesProperty.IncludeSubscription``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includesubscription </remarks>
        [JsiiProperty("includeSubscription", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object IncludeSubscription
        {
            get;
            set;
        }

        /// <summary>``BudgetResource.CostTypesProperty.IncludeSupport``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includesupport </remarks>
        [JsiiProperty("includeSupport", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object IncludeSupport
        {
            get;
            set;
        }

        /// <summary>``BudgetResource.CostTypesProperty.IncludeTax``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includetax </remarks>
        [JsiiProperty("includeTax", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object IncludeTax
        {
            get;
            set;
        }

        /// <summary>``BudgetResource.CostTypesProperty.IncludeUpfront``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includeupfront </remarks>
        [JsiiProperty("includeUpfront", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object IncludeUpfront
        {
            get;
            set;
        }

        /// <summary>``BudgetResource.CostTypesProperty.UseAmortized``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-useamortized </remarks>
        [JsiiProperty("useAmortized", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object UseAmortized
        {
            get;
            set;
        }

        /// <summary>``BudgetResource.CostTypesProperty.UseBlended``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-useblended </remarks>
        [JsiiProperty("useBlended", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object UseBlended
        {
            get;
            set;
        }
    }
}
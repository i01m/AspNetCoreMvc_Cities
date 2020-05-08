using Microsoft.AspNetCore.Razor.TagHelpers;


namespace Cities.Infrastructure.TagHelpers
{
    //Narrowing the scope - Making it applied only to buttons which have bs-button-color attribute
    //[HtmlTargetElement("button", Attributes="bs-button-color", ParentTag ="form")]

    //Widening the scope - applies to any element which has attribute bs-button-color
    //[HtmlTargetElement(Attributes = "bs-button-color", ParentTag = "form")]

    //specifiying the complete set of elements
    [HtmlTargetElement("button", Attributes = "bs-button-color", ParentTag = "form")]
    [HtmlTargetElement("a", Attributes = "bs-button-color", ParentTag = "form")]
    public class ButtonTagHelper : TagHelper
    {
        public string BsButtonColor { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"btn btn-{BsButtonColor}");
        }
    }
}

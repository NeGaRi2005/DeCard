#pragma checksum "D:\Webs\NeGar\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "777912cff2f49c4e1709105588859aedbd8fa0b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Webs\NeGar\Views\_ViewImports.cshtml"
using NeGar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Webs\NeGar\Views\_ViewImports.cshtml"
using NeGar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"777912cff2f49c4e1709105588859aedbd8fa0b6", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0657f6a070f0f137e19b06c88a766d16b35d2012", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sticky_header"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html class=\"no-js\" lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777912cff2f49c4e1709105588859aedbd8fa0b63505", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>CleanStart | قالب فارسی | میهن وبمستر</title>
    <meta name=""apple-mobile-web-app-capable"" content=""yes"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no"" />
    <meta name=""HandheldFriendly"" content=""true"" />
    <meta name=""apple-touch-fullscreen"" content=""yes"" />
    <!-- All Animations CSS -->
    <link href=""css/animate.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""css/animate-rtl.css"" rel=""stylesheet"" type=""text/css"">
    <!-- Image Lightbox CSS-->
    <link rel=""stylesheet"" href=""css/imagelightbox.css"" type=""text/css"" media=""screen"">
    <link rel=""stylesheet"" href=""css/imagelightbox-rtl.css"" type=""text/css"" media=""screen"">
    <!-- Theme styles and Menu styles -->
    <link href=""css/style.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""css/style-rtl.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""css/mainmenu.css"" rel=""stylesheet"" type=""text/css"">
    <link hre");
                WriteLiteral(@"f=""css/mainmenu-rtl.css"" rel=""stylesheet"" type=""text/css"">
    <!-- Call Fontawsome Icon Font from a CDN -->
    <link href=""http://netdna.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css"" rel=""stylesheet"">
    <!--Pace Page Loader -->
    <link rel=""stylesheet"" href=""js/pace-0.5.1/themes/pace-theme-minimal.css"" type=""text/css"" media=""screen"" />
    <!--FlexSlider -->
    <link rel=""stylesheet"" href=""js/woothemes-FlexSlider-06b12f8/flexslider.css"" type=""text/css"" media=""screen"">
    <!--Isotope Plugin -->
    <link rel=""stylesheet"" href=""js/isotope/css/style.css"" type=""text/css"" media=""screen"">
    <!--Simple Text Rotator -->
    <link href=""css/simpletextrotator.css"" rel=""stylesheet"" type=""text/css"">
    <!--Style Switcher, You propably want to remove this!-->
    <link href=""css/_style_switcher.css"" rel=""stylesheet"" type=""text/css"">
    <!--Modernizer Custom -->
    <script type=""text/javascript"" src=""js/modernizr.custom.48287.js""></script>
    <!-- Fav and touch icons -->
    <l");
                WriteLiteral(@"ink rel=""apple-touch-icon-precomposed"" sizes=""114x114"" href=""apple-touch-icon-114x114-precomposed.png"">
    <link rel=""apple-touch-icon-precomposed"" sizes=""72x72"" href=""apple-touch-icon-72x72-precomposed.png"">
    <link rel=""apple-touch-icon-precomposed"" href=""apple-touch-fa-57x57-precomposed.html"">
    <link rel=""shortcut icon"" href=""favicon.png"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777912cff2f49c4e1709105588859aedbd8fa0b67077", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 42 "D:\Webs\NeGar\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div class=""overflow_wrapper"">
        <header>
            <div class=""container"">
                <div class=""logo""><a class=""brand"" href=""index.html""> <img src=""images/cleanstart_logo.png"" alt=""optional logo""> <span class=""logo_title"">کلین استارت</span></a></div>
                <div id=""mainmenu"" class=""menu_container"">
                    <label class=""mobile_collapser"">منو</label>
                    <!-- Mobile menu title -->
                    <ul>
                        <li class=""active""><a href=""index.html"">خانه</a></li>
                        <li><a href=""about_us.html"">درباره ما</a></li>
");
                WriteLiteral(@"                        <li><a href=""portfolio.html"">نمونه کار</a></li>
                        <li><a href=""blog.html"">وبلاگ</a></li>
                        <li><a href=""contact.html"">تماس با ما</a></li>
                        <li>
                            <a href=""#"">ویژگی ها</a>
                            <div class=""dmui_dropdown_block full_width"" style=""background-image: url(images/mega_menu_background.png); background-repeat:no-repeat; background-position:-70px;width:500px;"">
                                <div class=""dmui-container"">
                                    <div class=""dmui-col span3"">
                                        <div class=""dmui-container"">
                                            <ul class=""dmui-submenu"">
                                                <li><a href=""home_alternative.html"">جایگزین خانه</a></li>
                                                <li><a href=""page_alternative.html"">جایگزین برگه</a></li>
                                          ");
                WriteLiteral(@"      <li><a href=""gallery.html"">نمونه کار ماسونری</a></li>
                                                <li><a href=""portfolio_item.html"">نمونه کار تکی</a></li>
                                                <li><a href=""portfolio_item_2.html"">نمونه کار تکی 2</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class=""dmui-col span3"">
                                        <div class=""dmui-container"">
                                            <ul class=""dmui-submenu"">
                                                <li><a href=""single_post.html"">نوشته تکی</a></li>
                                                <li><a href=""404.html"">خطای 404</a></li>
                                                <li><a href=""register.html"">ثبت نام یا ورود</a></li>
                                                <li><a href=""elements.html"">عناصر طراحی</a></li>
        ");
                WriteLiteral(@"                                        <li><a href=""documentation/index.html"">مستندات <span class=""label label-danger"">جدید</span></a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
                <div class=""triangle-up-left""></div>
                <div class=""triangle-up-right""></div>
            </div>
        </header>
        <div class=""full_page_photo"" style=""background-image: url(images/services.jpg);"">
            <div class=""hgroup"">
                <div class=""hgroup_title animated bounceInUp"">
                    <div class=""container"">
                        <h1>خدمات</h1>
                    </div>
                </div>
                <div class=""hgroup_subtitle animated bounceInUp skincolored"">
                    <div cla");
                WriteLiteral(@"ss=""container"">
                        <p>ما برای مشکلات شما ایده داریم! </p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""main"">
            <div class=""container triangles-of-section"">
                <div class=""triangle-up-left""></div>
                <div class=""square-left""></div>
                <div class=""triangle-up-right""></div>
                <div class=""square-right""></div>
            </div>
            <section class=""horizontal_teaser"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-sm-12 col-md-4 horizontal_teaser_left"">
                            <h3>به دورنمای ما اعتماد کنید!</h3>
                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارها");
                WriteLiteral(@"ی کاربردی می باشد. </p>
                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. </p>
                        </div>
                        <div class=""col-sm-12 col-md-8 horizontal_teaser_right"">
                            <!--<figure style=""background-image:url(images/portfolio/t4.jpg)""> </figure>-->
                            <div class=""twentytwenty-container""> <img src=""images/img_after.jpg"" alt=""after"" /> </div>
                        </div>
                    </div>
                </div>
            </section>
            <section class=""services_teasers dark_section"">
                <div class=""container triangles-of-section"">
                    <div class=""triangle-up-left""></div>
                    <div class=""square-left""></div>
                    <di");
                WriteLiteral(@"v class=""triangle-up-right""></div>
                    <div class=""square-right""></div>
                </div>
                <div class=""container"">
                    <h2 class=""section_header fancy centered"">خدماتی که ارائه می دهیم<small>بیش از نیازهای شماست</small></h2>
                    <div class=""row"">
                        <div class=""col-sm-4 col-md-4"">
                            <div class=""service_teaser vertical"">
                                <div class=""service_photo"">
                                    <figure style=""background-image:url(images/serv_4.jpg)""></figure>
                                </div>
                                <div class=""service_details"">
                                    <h2>طراحی</h2>
                                    <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. </p>
                             ");
                WriteLiteral(@"   </div>
                            </div>
                        </div>
                        <div class=""col-sm-4 col-md-4"">
                            <div class=""service_teaser vertical"">
                                <div class=""service_photo"">
                                    <figure style=""background-image:url(images/serv_5.jpg)""></figure>
                                </div>
                                <div class=""service_details"">
                                    <h2>توسعه</h2>
                                    <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. </p>
                                    <a class=""btn btn-primary"" href=""documentation/index.html"">همین حالا تماس بگیرید</a>
                                </div>
                            </div>
                        </div>
                        <div class=""col-s");
                WriteLiteral(@"m-4 col-md-4"">
                            <div class=""service_teaser vertical"">
                                <div class=""service_photo"">
                                    <figure style=""background-image:url(images/serv_1.jpg)""></figure>
                                </div>
                                <div class=""service_details"">
                                    <h2>پشتیبانی</h2>
                                    <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <section class=""pricing_wrapper"">
                <div class=""container triangles-of-section"">
                    <div class=""triangle-up-left""></div>
                    <div class=""squar");
                WriteLiteral(@"e-left""></div>
                    <div class=""triangle-up-right""></div>
                    <div class=""square-right""></div>
                </div>
                <div class=""container"">
                    <h2 class=""section_header fancy centered"">پلن های ارائه خدمات<small>ما همیشه مطابق نیاز شما پلن داریم</small></h2>
                    <div class=""row"">
                        <div class=""col-sm-4 col-md-4"">
                            <div class=""pricing_plan wow fadeInUp"">
                                <h3>پلن کوچک <small>برای شروع بکار</small></h3>
                                <div class=""the_price""><span>هزارتومان</span>150</div>
                                <div class=""the_offerings"">
                                    <p> <strong>1</strong> طراحی قالب </p>
                                    <p> <strong>2</strong> فرم تماس </p>
                                    <p> <strong>5</strong> صفحه HTML </p>
                                </div>
                                <a");
                WriteLiteral(@" href=""#"" class=""btn btn-primary"">انتخاب کنید</a>
                            </div>
                        </div>
                        <div class=""col-sm-4 col-md-4"">
                            <div class=""pricing_plan special wow fadeInUp"">
                                <h3>پلن متوسط <small>پلنی که باید انتخاب کنید</small></h3>
                                <div class=""the_price""><span>هزار تومان</span>250</div>
                                <div class=""the_offerings"">
                                    <p> <strong>1</strong> طراحی قالب </p>
                                    <p> <strong>2</strong> فرم تماس </p>
                                    <p> <strong>5</strong> صفحه HTML </p>
                                </div>
                                <a href=""#"" class=""btn btn-primary"">انتخاب کنید</a>
                            </div>
                        </div>
                        <div class=""col-sm-4 col-md-4"">
                            <div class=""pricing_plan w");
                WriteLiteral(@"ow fadeInUp"">
                                <h3>پلن حرفه ای <small>این چیزی است واقعا نیاز دارید</small></h3>
                                <div class=""the_price""><span>هزار تومان</span>350</div>
                                <div class=""the_offerings"">
                                    <p> <strong>1</strong> طراحی قالب </p>
                                    <p> <strong>2</strong> فرم تماس </p>
                                    <p> <strong>5</strong> صفحه HTML </p>
                                </div>
                                <a href=""#"" class=""btn btn-primary"">انتخاب کنید</a>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <section class=""parallax skincolored call_to_action"" style=""background-image:url(images/parallax.jpg)"">
                <div class=""overlay"">
                    <img alt=""responsive"" src=""images/bear.png"">
                    <h3>ما محصولات با ارزش ب");
                WriteLiteral(@"رای مشتریان خود طراحی میکنیم</h3>
                    <h4>مشتریان ما همیشه خوشحال و راضی هستند!</h4>
                </div>
            </section>
            <footer>
                <section class=""footer_teasers_wrapper dark_section"">
                    <div class=""container triangles-of-section"">
                        <div class=""triangle-up-left""></div>
                        <div class=""square-left""></div>
                        <div class=""triangle-up-right""></div>
                        <div class=""square-right""></div>
                    </div>
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""footer_teaser pl_about_us_widget col-sm-4 col-md-4"">
                                <h3>در تماس باشید</h3>
                                <p>
                                    میهن وبمستر <small>منابع طراحی وب و گرافیک</small><br>
                                    ایران تهران خ شهید مطهری برج آزادی پ 007
 ");
                WriteLiteral(@"                               </p>
                                <p><i class=""fa fa-envelope""></i> contact@example.com</p>
                                <p><i class=""fa fa-phone""></i> (+98) 265-9987</p>
                                <div class=""footer_social"">
                                    <div class=""social_wrapper""><a href=""https://www.facebook.com/mihanwebmaster""><i class=""fa fa-facebook""></i></a> <a href=""#""><i class=""fa fa-youtube""></i></a> <a href=""#googleplus""><i class=""fa fa-google-plus""></i></a></div>
                                </div>
                            </div>
                            <div class=""footer_teaser pl_latest_news_widget col-sm-4 col-md-4"">
                                <h3>آخرین اخبار</h3>
                                <ul class=""media-list"">
                                    <li class=""media"">
                                        <a href=""#"" class=""media-photo"" style=""background-image:url(images/portfolio/t5.jpg)""></a> <a href=""#"" class=""");
                WriteLiteral(@"media-date"">19<span>مرداد</span></a>
                                        <h5 class=""media-heading""><a href=""#"">عنوان آخرین خبر در این محل نوشته می شود...</a></h5>
                                        <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است...</p>
                                    </li>
                                    <li class=""media"">
                                        <a href=""#"" class=""media-photo"" style=""background-image:url(images/portfolio/t4.jpg)""></a> <a href=""#"" class=""media-date"">18<span>تیر</span></a>
                                        <h5 class=""media-heading""><a href=""#"">یک عنوان دیگر از خبر...</a></h5>
                                        <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است...</p>
                                    </li>
                                </ul>
                            </div>
                            <div class=""footer_teaser ");
                WriteLiteral(@"pl_flickr_widget col-sm-4 col-md-4"" id=""latest-flickr-images"">
                                <h3>فلیکرفید</h3>
                                <ul>
                                </ul>
                            </div>
                        </div>
                    </div>
                </section>
                <div class=""copyright"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-sm-4 col-md-4"">کپی رایت  ©2014 تمامی حقوق محفوظ است </div>
                            <div class=""col-sm-4 col-md-4""></div>
                            <div class=""text-right col-sm-4 col-md-4"">فارسی شده توسط <a href=""http://mihanwebmaster.com/"">میهن وبمستر</a> </div>
                        </div>
                    </div>
                </div>
            </footer>
        </div>
        <script src=""js/jquery-1.10.2.min.js""></script>
        <script src=""twitter-bootstrap/js/bootstrap.min.js"" type=""text/javascript""");
                WriteLiteral(@"></script>
        <!--Pace Page Loader -->
        <script src=""js/pace-0.5.1/pace.min.js""></script>
        <!--FlexSlider -->
        <script src=""js/woothemes-FlexSlider-06b12f8/jquery.flexslider-min.js""></script>
        <!--Isotope Plugin -->
        <script src=""js/isotope/jquery.isotope.min.js"" type=""text/javascript""></script>
        <!--To-Top Button Plugin -->
        <script type=""text/javascript"" src=""js/jquery.ui.totop.js""></script>
        <!--Easing animations Plugin -->
        <script type=""text/javascript"" src=""js/easing.js""></script>
        <!--WOW Reveal on scroll Plugin -->
        <script type=""text/javascript"" src=""js/wow.min.js""></script>
        <!--Simple Text Rotator -->
        <script type=""text/javascript"" src=""js/jquery.simple-text-rotator.js""></script>
        <!--The Theme Required Js -->
        <script type=""text/javascript"" src=""js/cleanstart_theme.js""></script>
        <!--To collapse the menu -->
        <script type=""text/javascript"" src=""js/collapser");
                WriteLiteral(".js\"></script>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

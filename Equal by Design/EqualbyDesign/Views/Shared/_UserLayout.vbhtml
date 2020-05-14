<!DOCTYPE html>
<html lang="en">
<head>

    <title>Equal by Design</title>

    <!--

    Template 2099 Scenic

    http://www.tooplate.com/view/2099-scenic

    -->

    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=Edge">
    <meta name="description" content="">
    <meta name="keywords" content="">
    <meta name="author" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">

    @Styles.Render("~/template/css")

</head>
<body>

    <!-- PRE LOADER -->
    <div class="preloader">
        <div class="spinner">
            <span class="sk-inner-circle"></span>
        </div>
    </div>

    <!-- MENU -->
    <div class="navbar custom-navbar navbar-fixed-top" role="navigation">
        <div class="container">

            <!-- NAVBAR HEADER -->
            <div class="navbar-header">
                <button class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon icon-bar"></span>
                    <span class="icon icon-bar"></span>
                    <span class="icon icon-bar"></span>
                </button>
                <!-- lOGO -->
                <a href="index.html" class="navbar-brand">Equal by Design</a>
            </div>

            <!-- MENU LINKS -->
            <div class="collapse navbar-collapse">
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="#home" class="smoothScroll">Home</a></li>
                    <li><a href="#about" class="smoothScroll">About Us</a></li>
                    <li><a href="#team" class="smoothScroll">Our Product</a></li>
                    <li><a href="#contact" class="smoothScroll">Get in Touch</a></li>
                </ul>
            </div>

        </div>
    </div>

    @RenderBody()

    <!-- SCRIPTS -->
    @Scripts.Render("~/template/js")



</body>
</html>

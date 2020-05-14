<!-- HOME -->
    <section id="home" class="parallax-section">
        <div class="overlay"></div>
        <div class="container">
            <div class="row">

                <div class="col-md-8 col-sm-12">
                    <div class="home-text">
                        <h1>Equal by Design</h1>
                        <p>Feel free to check out our web accessibility tool for an easier web experience</p>
                        <ul class="section-btn">
                            <a href="#team" class="smoothScroll"><span data-hover="Discover More">Discover More</span></a>
                        </ul>
                    </div>
                </div>

            </div>
        </div>

        <!-- Video -->
        <video controls autoplay loop muted>
            <source src="~/Content/videos/video.mp4" type="video/mp4">
            Your browser does not support the video tag.
        </video>
    </section>


    <!-- ABOUT -->
    <section id="about" class="parallax-section">
        <div class="container">
            <div class="row">

                <div class="col-md-offset-1 col-md-10 col-sm-12">
                    <div class="about-info">
                        <h3>Who are we?</h3>
                        <h1>Equal by design is a small company that aims to assist all types of users with their web experience. Currently, it is focused 
                        heavily on assisting those with visual issues and impairments, such as Protanopia, Deuteranopia or even something as rare as Monochromacy.
                        </h1>
                    </div>
                </div>

            </div>
        </div>
    </section>

    

    <!-- PROJECT -->
    <section id="project" class="parallax-section">
        <div class="container">
            <div class="row">

                <div class="col-md-6 col-sm-6">
                    <!-- PROJECT ITEM -->
                    <div class="project-item">
                        <a href="images/project-image1.jpg" class="image-popup">
                            <img src="~/Content/images/project-image1.jpg" class="img-responsive" alt="">

                            <div class="project-overlay">
                                <div class="project-info">
                                    <h1>How does our WebViewer1.0 work?</h1>
                                    <h3>Click for more information</h3>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>

                <div class="col-md-6 col-sm-6">
                    <!-- PROJECT ITEM -->
                    <div class="project-item">
                        <a href="images/project-image2.jpg" class="image-popup">
                            <img src="~/Content/images/project-image2.jpg" class="img-responsive" alt="">

                            <div class="project-overlay">
                                <div class="project-info">
                                    <h1>Who can Equal by Design help?</h1>
                                    <h3>Click for more information</h3>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </section>


    <!-- TEAM -->
    <section id="team" class="parallax-section">
        <div class="container">
            <div class="row">

                <div class="col-md-offset-2 col-md-8 col-sm-12">
                    <!-- SECTION TITLE -->
                    <div class="section-title">
                        <h1>WebViewer1.0</h1>
                    </div>
                </div>

                        <div class="team-item">
                            <iframe is="x-frame-bypass" id="webViewer" src="https://bbc.co.uk/news">
                                <p>Your browser does not support iframes.</p>
                            </iframe>
                    </div>

                </div>

            </div>
        
    </section>


    <!-- CONTACT -->
    <section id="contact" class="parallax-section">
        <div class="container">
            <div class="row">

                <div class="col-md-offset-3 col-md-6 col-sm-12">
                    <div class="section-title">
                        <h1>Talk to us!</h1>
                    </div>
                </div>

                <div class="clearfix"></div>

                <div class="col-md-offset-2 col-md-8 col-sm-12">
                    <!-- CONTACT FORM HERE -->
                    <form id="contact-form" action="#" method="get" role="form">

                        <!-- IF MAIL SENT SUCCESSFULLY -->
                        <h6 class="text-success">Your message has been sent successfully. </h6>

                        <!-- IF MAIL SENDING UNSUCCESSFULL -->
                        <h6 class="text-danger">E-mail must be valid and message must be longer than 1 character.</h6>

                        <div class="col-md-6 col-sm-6">
                            <input type="text" class="form-control" id="cf-name" name="cf-name" placeholder="Name">
                        </div>

                        <div class="col-md-6 col-sm-6">
                            <input type="email" class="form-control" id="cf-email" name="cf-email" placeholder="Email Address">
                        </div>

                        <div class="col-md-12 col-sm-12">
                            <input type="text" class="form-control" id="cf-subject" name="subject" placeholder="Subject">
                            <textarea class="form-control" rows="5" id="cf-message" name="cf-message" placeholder="Message"></textarea>
                        </div>

                        <div class="col-md-offset-4 col-md-4 col-sm-offset-4 col-sm-4">
                            <div class="section-btn">
                                <button type="submit" class="form-control" id="cf-submit" name="submit"><span data-hover="Send Message">Send Message</span></button>
                            </div>
                        </div>
                    </form>
                </div>

            </div>
        </div>
    </section>

    

    <!-- FOOTER -->
    <footer>
        <div class="container">
            <div class="row">

                <div class="col-md-5 col-sm-6">
                    <h2>Equal By Design</h2>
                </div>
            </div>
        </div>
    </footer>
    <!-- External script used to enable x-frame-bypass options: DENY, NONE, SAMEORIGIN for iframe ctnt display -->
        <script type="module" src="https://unpkg.com/x-frame-bypass"></script>
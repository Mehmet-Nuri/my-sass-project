@import url("https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css");
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

.link-style a, footer.vertical .social-icons a, footer.horizontal a {
  padding: 0.4rem;
  transition: all 1s;
}
.link-style a:hover, footer.vertical .social-icons a:hover, footer.horizontal a:hover {
  color: #ff652f;
}

footer.horizontal {
  height: 10vh;
  display: flex;
  justify-content: space-between;
  align-items: flex-end;
  padding: 1rem;
}

footer.vertical {
  display: flex;
  justify-content: space-between;
  align-items: flex-end;
  padding: 2rem;
  margin-bottom: 1rem;
}
footer.vertical .social-icons {
  display: flex;
  flex-direction: column;
  position: fixed;
  bottom: 1rem;
}
footer.vertical .copyright {
  position: fixed;
  bottom: 1rem;
  right: 3rem;
  writing-mode: vertical-rl;
  text-orientation: mixed;
}

.nav {
  padding: 1rem;
  height: 10vh;
}
.nav__list {
  text-align: right;
}
.nav__item {
  display: inline;
  padding: 1rem;
}
.nav__link {
  font-size: 1rem;
  text-transform: uppercase;
  font-weight: 500;
  font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
  transition: all 1s;
}
.nav__link:hover {
  color: blue;
}
.nav__link--active {
  color: #ff652f;
}

.about-bgImg-container {
  height: 50vh;
  width: 100%;
  background: linear-gradient(to right, rgba(39, 39, 39, 0.9), rgba(39, 39, 39, 0.3)), url("../img/model-1.jpg");
  background-position: center center;
  background-size: cover;
  display: flex;
  justify-content: space-between;
  flex-direction: column;
}
.about-bgImg-container .about__bio-image {
  text-align: center;
}
.about-bgImg-container .about__bio-image h2 {
  font-size: 3rem;
  color: #ff652f;
}
.about-bgImg-container .about__bio-image p {
  font-size: 1.2rem;
  margin: 2rem;
}

.about__container {
  width: 70vh;
  margin: 2rem auto;
}
.about .about__job {
  margin: 1rem;
  background: #414141;
  padding: 1rem;
  border-bottom: 5px solid #ff652f;
}
.about .about__job h2, .about .about__job h3 {
  margin: 0.5rem, 0;
}
.about .about__job h6 {
  margin: 0.3rem 0;
}

.contact-bgImg-container {
  height: 100vh;
  width: 100%;
  background: linear-gradient(to right, rgba(39, 39, 39, 0.9), rgba(39, 39, 39, 0.3)), url("../img/model-1.jpg");
  background-position: center center;
  background-size: cover;
}
.contact-bgImg-container nav {
  height: 40vh;
}

.home-bgImg-container {
  height: 100vh;
  width: 100%;
  background: linear-gradient(to right, rgba(39, 39, 39, 0.9), rgba(39, 39, 39, 0.3)), url("../img/model-1.jpg");
  background-position: center center;
  background-size: cover;
}

.home {
  height: 80vh;
  display: flex;
  flex-direction: column;
  justify-content: center;
  text-align: center;
}
.home__name {
  font-size: 5rem;
  padding: 1rem;
  margin-bottom: 1rem;
  border-bottom: 2px solid #fff;
}
.home__name--last {
  color: red;
  font-weight: 700;
}

.project-bgImg-container {
  height: 40vh;
  width: 100%;
  background: linear-gradient(to right, rgba(39, 39, 39, 0.9), rgba(39, 39, 39, 0.3)), url("../img/model-1.jpg");
  background-position: center center;
  background-size: cover;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
}
.project-bgImg-container .projects__bio-image {
  text-align: center;
  margin-bottom: 0.5rem;
}

.projects__items {
  width: 100%;
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  padding: 2rem 5rem;
  gap: 1rem 0;
}
.projects__item {
  width: 100%;
  cursor: pointer;
  border-bottom: 5px solid #ff652f;
  position: relative;
}
.projects__item img {
  width: 100%;
}
.projects__item::after {
  content: "";
  height: 100%;
  width: 100%;
  background-color: #ff652f;
  position: absolute;
  left: 0;
  opacity: 0;
  transition: all 0.5s;
}
.projects__item:hover::after {
  opacity: 0.7;
}

body {
  font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
  line-height: 1;
  color: #eee;
  background-color: #272727;
  height: 100vh;
}

a {
  text-decoration: none;
  color: #eee;
}

h1,
h2,
h3 {
  font-weight: 400;
}

/*# sourceMappingURL=main.cs.map */

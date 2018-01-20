import "./css/site.css";
import Vue from "vue";
import fav from "../Images/favicon.ico";
import "font-awesome-webpack";
import 'opensans-npm-webfont';

new Vue({
  el: "#app",
  render: h => h(require("./components/app/app.vue.html"))
});

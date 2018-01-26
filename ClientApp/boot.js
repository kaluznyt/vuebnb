import Vue from "vue";

import fav from "../wwwroot/Images/favicon.ico";

import "font-awesome-webpack";
import "opensans-npm-webfont";

const app = new Vue({
  el: "#app",
  render: app => app(require("./components/app/app.vue"))
});
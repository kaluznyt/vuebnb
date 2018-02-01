import Vue from "vue";

import fav from "../wwwroot/Images/favicon.ico";

import "font-awesome-webpack";
import "opensans-npm-webfont";

import App from "./components/app/app.vue";

const app = new Vue({
  el: "#app",
  render: app => app(App)
});
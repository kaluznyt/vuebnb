import Vue from "vue";

import fav from "../wwwroot/Images/favicon.ico";

import "font-awesome-webpack";
import "opensans-npm-webfont";

import ListingPage from "./components/ListingPage/ListingPage.vue";
import router from './router';

const app = new Vue({
  el: "#app",
  render: app => app(ListingPage),
  router
});
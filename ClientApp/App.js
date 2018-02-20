import Vue from "vue";
import VueRouter from "vue-router";
Vue.use(VueRouter);

import fav from "../wwwroot/Images/favicon.ico";

import "font-awesome-webpack";
import "opensans-npm-webfont";

import App from "./components/App.vue";

import router from './js/router';
import store from './js/store'

var app = new Vue({
  el: "#app",
  render: app => app(App),
  router,
  store
});
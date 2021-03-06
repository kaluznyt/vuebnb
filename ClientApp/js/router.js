import Vue from "vue";
import VueRouter from "vue-router";
Vue.use(VueRouter);

import ListingPage from "../components/ListingPage/ListingPage.vue";
import HomePage from "../components/Homepage.vue";

export default new VueRouter({
  mode: "history",
  routes: [
    {
      path: "/",
      component: HomePage,
      name: "home"
    },
    {
      path: "/listing/:listing",
      component: ListingPage,
      name: "listing"
    }
  ],
  scrollBehavior(to, from, savedPosition) {
    if (to.name === "listing")
      return {
        x: 0,
        y: 0
      };
    else return savedPosition;
  }
});

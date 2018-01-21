import Vue from "vue";
import logo from "../../../wwwroot/Images/logo.png";
import ImageCarousel from "../ImageCarousel.vue";

const model = window.vuebnbListingModel;

const data = function () {
  return Object.assign(model, {
    logo: logo,
    contracted: true,
    modalOpen: false
  });
};

export default {
  data: data,
  components: {
    ImageCarousel
  }
};
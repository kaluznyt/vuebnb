import Vue from "vue";
import logo from "../../../wwwroot/Images/logo.png";
import Toolbar from "./Toolbar.vue";
import PageHeader from "./PageHeader.vue";
import Modal from "../modal/Modal.vue";

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
    Toolbar,
    PageHeader,
    Modal
  }
};
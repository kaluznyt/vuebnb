import Vue from "vue";
import logo from "../../../wwwroot/Images/logo.png";
import Toolbar from "./Toolbar.vue";
import PageHeader from "./PageHeader.vue";
import Modal from "../modal/Modal.vue";
import ImageCarousel from "../image-carousel/ImageCarousel.vue";

const model = window.vuebnbListingModel;

const data = function () {
  return Object.assign(model, {
    logo: logo,
    contracted: true
  });
};

export default {
  data: data,
  methods: {
    openModal() {
      this.$refs.imagemodal.modalOpen = true;
    }
  },
  components: {
    Toolbar,
    PageHeader,
    Modal,
    ImageCarousel
  }
};
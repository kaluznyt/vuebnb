import Vue from "vue";
import logo from "../../../wwwroot/Images/logo.png";
import Toolbar from "../Toolbar.vue";
import PageHeader from "../PageHeader.vue";
import Modal from "../Modal.vue";
import ImageCarousel from "../ImageCarousel.vue";
import FeatureList from "../FeatureList.vue";
import ExpandableText from "../ExpandableText.vue";

const model = window.vuebnbListingModel;

const data = function () {
  return Object.assign(model, {
    logo: logo
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
    ImageCarousel,
    FeatureList,
    ExpandableText
  }
};
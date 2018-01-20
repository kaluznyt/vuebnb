import Vue from "vue";
import headerImg from "../../../Images/header.jpg";
import logo from "../../../Images/logo.png";
import data from "../../../sample/data.js";

export default {
  data: function() {
    return {
      headerImg: headerImg,
      logo: logo,
      title: data.title,
      address: data.address,
      about: data.about,
      amenities: data.amenities,
      prices: data.prices,
      contracted: true,
      modalOpen: false
    };
  }
};

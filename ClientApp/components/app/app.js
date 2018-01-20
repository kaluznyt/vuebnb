import Vue from "vue";
import headerImg from "../../../Images/header.jpg";
import logo from "../../../Images/logo.png";
//import sampleData from "../../../sample/data";
import style from "app";

const model = window.vuebnbListingModel;

const data = function() {
  return Object.assign(model, {
    headerImg: headerImg,
    logo: logo,
    contracted: true,
    modalOpen: false
  });
};

export default {
  data: data
};

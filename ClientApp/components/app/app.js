import Vue from "vue";
//import headerImg from "../../../Images/header.jpg";
import logo from "../../../wwwroot/Images/logo.png";
//import sampleData from "../../../sample/data";
import style from "./app.less";

const model = window.vuebnbListingModel;

const data = function() {
  return Object.assign(model, {
    //  headerImg: headerImg,
    logo: logo,
    contracted: true,
    modalOpen: false
  });
};

export default {
  data: data
};

import Vue from "vue";
import fav from "../wwwroot/Images/favicon.ico";
import "font-awesome-webpack";
import "opensans-npm-webfont";

Vue.component("image-carousel", {
  props: ["images"],
  template: `
            <div class="image-carousel">
                <img v-bind:src="image"/>
                <div class="controls">
                  <carousel-control></carousel-control>
                  <carousel-control></carousel-control>
                </div>
            </div>
            `,
  data() {
    return {
      // images: [
      //   "images/listings/1/Image_1.jpg",
      //   "images/listings/2/Image_2.jpg",
      //   "images/listings/3/Image_3.jpg",
      //   "images/listings/4/Image_4.jpg"
      // ],
      index: 0,
      intervals: {
        changeImage: ""
      }
    };
  },
  computed: {
    image() {
      return this.images[this.index % this.images.length];
    }
  },
  methods: {
    changeImage(interval) {
      this.intervals.changeImage = setInterval(() => {
        this.index++;
      }, interval);
    }
  },
  mounted() {
    this.changeImage(5000);
  },
  beforeDestroy() {
    clearInterval(this.intervals.changeImage);
    console.log("Destroying...");
  },
  components: {
    "carousel-control": {
      template: `<i class="image-carousel-control fa fa-2x fa-chevron-left"></i>`
    }
  }
});

const app = new Vue({
  el: "#app",
  render: app => app(require("./components/app/app.vue.html"))
});

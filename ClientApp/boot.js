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
                  <carousel-control @change-image="changeImage" dir="left"></carousel-control>
                  <carousel-control @change-image="changeImage" dir="right"></carousel-control>
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
      timers: {
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
      if (interval < 2) {
        this.index +=
          this.index === 0 ? (interval === 1 ? interval : 0) : interval;
      } else {
        this.timers.changeImage = setInterval(() => {
          this.index++;
        }, interval);
      }
    }
  },
  mounted() {
    this.changeImage(5000);
  },
  beforeDestroy() {
    clearInterval(this.timers.changeImage);
    console.log("Destroying...");
  },
  components: {
    "carousel-control": {
      template: `<i :class="classes" @click="clicked"></i>`,
      props: ["dir"],
      computed: {
        classes() {
          return "image-carousel-control fa fa-2x fa-chevron-" + this.dir;
        }
      },
      methods: {
        clicked() {
          this.$emit("change-image", this.dir === "left" ? -1 : 1);
        }
      }
    }
  }
});

const app = new Vue({
  el: "#app",
  render: app => app(require("./components/app/app.vue.html"))
});

<template>
  <div class="listing-save" @click.stop="toggleSaved()">
    <button v-if="button">
      <i :class="classes"></i>
      {{ message }}
    </button>
    <i v-else :class="classes"></i>
  </div>
</template>
<script>
export default {
  props: ["id", "button"],
  methods: {
    toggleSaved() {
      this.$store.commit("toggleSaved", this.id);
    }
  },
  computed: {
    isListingSaved() {
      return this.$store.state.saved.find(saved => saved === this.id);
    },
    message() {
      return "Save" + (this.isListingSaved ? "d" : "");
    },
    classes() {
      let saved = this.isListingSaved;

      return {
        fa: true,
        "fa-lg": true,
        "fa-heart": saved,
        "fa-heart-o": !saved
      };
    }
  }
};
</script>

<style lang="less" scoped>
.listing-save {
  position: absolute;
  top: 20px;
  left: 20px;
  cursor: pointer;

  .fa-heart {
    color: #ff5a5f;
  }

  .fa-heart-o {
    color: #fff;
  }

  i {
    padding-right: 4px;
  }

  button .fa-heart-o {
    color: #808080;
  }
}
</style>



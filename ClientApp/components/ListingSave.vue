<template>
    <div id="listing-save" @click.stop="toggleSaved()">
        <i :class="classes"></i>
    </div>
</template>
<script>
export default {
  props: ["id"],
  methods: {
    toggleSaved() {
      this.$store.commit("toggleSaved", this.id);
    }
  },
  computed: {
    isListingSaved() {
      return this.$store.state.saved.find(saved => saved === this.id);
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
#listing-save {
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
}
</style>



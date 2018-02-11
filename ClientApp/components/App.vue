<template>
  <div>
    <toolbar></toolbar>
    <router-view></router-view>
    <custom-footer></custom-footer>
  </div>
</template>
<script>
import Toolbar from "./Toolbar.vue";
import CustomFooter from "./CustomFooter.vue";

export default {
  components: {
    Toolbar,
    CustomFooter
  }
};
</script>
<style lang="less">

</style>



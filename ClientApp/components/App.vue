<template>
  <div>
    <toolbar></toolbar>
    <router-view></router-view>
  </div>
</template>
<script>
import Toolbar from "./Toolbar.vue";

export default {
  components: {
    Toolbar
  }
};
</script>



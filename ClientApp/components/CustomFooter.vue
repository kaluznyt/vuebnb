<template>
    <div id="footer">
        <div class="hr"></div>
        <div class="container">
            <p>
                <img src="/images/logo_grey.png" alt="logo" class="icon">
                <span>
                    <strong>Vuebnb</strong>. A full-stack Vue.js and Laravel demo app
                </span>
            </p>
        </div>
    </div>
</template>
<style lang="less" scoped>
#footer {
  margin-bottom: 3em;

  .icon {
    height: 23px;
    display: inline-block;
    margin-bottom: -6px;
  }

  p {
    font-size: 15px;
    color: #767676 !important;
    display: flex;
    width: 400px;
    margin-left: auto;
    margin-right: auto;

    img {
      padding-right: 6px;
    }
  }
}

.hr {
  border-bottom: 1px solid #dbdbdb;
  margin: 3em 0;
}
</style>


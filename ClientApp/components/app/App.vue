<template>
    <div>
        <toolbar :icon="logo"></toolbar>
        <div>
            <page-header :image="headerImage" @open-image-viewer="modalOpen=true"></page-header>
            <div class="container">
                <div class="heading">
                    <h1>{{title}}</h1>
                    <p>{{address}}</p>
                    <hr>
                    <div class="about">
                        <h3>About this listing</h3>
                        <p v-bind:class="{contracted: contracted}">{{about}}</p>
                        <button class="more" v-on:click="contracted=!contracted"> {{ contracted ? "+ More" : "- Less" }}</button>
                    </div>
                    <div class="lists">
                        <hr>
                        <div class="amenities list">
                            <div class="title">
                                <strong>Amenities</strong>
                            </div>
                            <div class="content">
                                <div class="list-item" v-for="amenity in amenities">
                                    <i class="fa fa-lg" v-bind:class="amenity.icon"></i>
                                    <span>{{amenity.title}}</span>
                                </div>
                            </div>
                        </div>
                        <hr>
                        <div class="prices list">
                            <div class="title">
                                <strong>Prices</strong>
                                <div class="content">
                                    <div class="list-item" v-for="price in prices">
                                        {{ price.title }}:
                                        <strong> {{ price.value }}</strong>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="modal" v-bind:class="{ show : modalOpen }">
                <button v-on:click="modalOpen = false" class="modal-close"> &times; </button>
                <div class="modal-content">
                    <image-carousel :images="Images"></image-carousel>
                </div>
            </div>
        </div>
    </div>
</template>

<script src="./app.js">
</script>
<style lang="less" src="./app.less">

</style>

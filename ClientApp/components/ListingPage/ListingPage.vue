<template>
    <div>
        <div>
            <page-header v-if="headerImage" :image="headerImage" @header-clicked="openModal" :id="id"></page-header>
            <div class="container">
                <div class="heading">
                    <h1>{{ title }}</h1>
                    <p>{{ address }}</p>
                    <hr>
                    <div class="about">
                        <h3>About this listing</h3>
                        <expandable-text>
                            {{ about }}
                        </expandable-text>
                    </div>
                    <div class="lists">
                        <feature-list title="Amenities" :items="amenities">
                            <template slot-scope="amenity">
                                <i class="fa fa-lg" :class="amenity.icon"></i>
                                <span>{{ amenity.title }}</span>
                            </template>
                        </feature-list>
                        <feature-list title="Prices" :items="prices">
                            <template slot-scope="price">
                                {{ price.title }}:
                                <strong> {{ price.value }}</strong>
                            </template>
                        </feature-list>
                    </div>
                </div>
            </div>
            <modal ref="imagemodal">
                <image-carousel :images="images"></image-carousel>
            </modal>
        </div>
    </div>
</template>

<script src="./ListingPage.js"></script>

<style lang="less" src="./ListingPage.less"></style>

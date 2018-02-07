<template>
    <div>
        <div>
            <page-header :image="listing.headerImage" @header-clicked="openModal"></page-header>
            <div class="container">
                <div class="heading">
                    <h1>{{ listing.title }}</h1>
                    <p>{{ listing.address }}</p>
                    <hr>
                    <div class="about">
                        <h3>About this listing</h3>
                        <expandable-text>
                            {{ listing.about }}
                        </expandable-text>
                    </div>
                    <div class="lists">
                        <feature-list title="Amenities" :items="listing.amenities">
                            <template slot-scope="amenity">
                                <i class="fa fa-lg" :class="amenity.icon"></i>
                                <span>{{ amenity.title }}</span>
                            </template>
                        </feature-list>
                        <feature-list title="Prices" :items="listing.prices">
                            <template slot-scope="price">
                                {{ price.title }}:
                                <strong> {{ price.value }}</strong>
                            </template>
                        </feature-list>
                    </div>
                </div>
            </div>
            <modal ref="imagemodal">
                <image-carousel :images="listing.Images"></image-carousel>
            </modal>
        </div>
    </div>
</template>

<script src="./ListingPage.js"></script>

<style lang="less" src="./ListingPage.less"></style>

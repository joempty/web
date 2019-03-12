<template>
  <div id="layout-sidenav" class="layout-sidenav sidenav sidenav-vertical bg-sidenav-theme">

    <!-- Brand -->
    <div class="app-brand">
      <img src="assets/img/logo.png" alt="" class="app-brand-logo ui-w-40">
      <a href="javascript:void(0)" class="app-brand-text sidenav-text text-big ml-2">JOVASOFT</a>
      <a href="javascript:void(0)" class="layout-sidenav-toggle sidenav-link text-large ml-auto">
        <i class="ion ion-md-menu align-middle"></i>
      </a>
    </div>
    <div class="sidenav-divider my-0"></div>
    <!-- / Brand -->

      <ul class="sidenav-inner">
        <li class="sidenav-item" v-for="(route, index) in routes" :key="index">
            <router-link :to="route.path" exact-active-class="active" class="sidenav-link">
              <icon :icon="route.icon" class="sidenav-icon ion ion-ios-contact"/>
              <span>{{route.display}}</span>
            </router-link>
        </li>
      </ul>
  </div>
</template>

<script>
    import { routes } from '../router/routes'

    export default {
      data () {
        return {
          routes,
          collapsed: true
        }
      },
      methods: {
      }
    }
</script>

<style scoped>
</style>

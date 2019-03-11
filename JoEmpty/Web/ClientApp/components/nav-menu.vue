<template>
  <div id="layout-sidenav" class="layout-sidenav sidenav sidenav-vertical bg-sidenav-theme">
    <ul class="sidenav-inner py-1">
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

<template>
    <!-- Layout wrapper -->
    <div class="layout-wrapper layout-2">
        <!-- Layout inner -->
        <div class="layout-inner">
            <nav-menu params="route: route"></nav-menu>
            <div class="layout-container" id="app">
                <nav-bar></nav-bar>
                <!-- Page content -->
                <div class="layout-content">
                    <div class="container-fluid flex-grow-1 container-p-y">
                        <router-view></router-view>
                    </div>
                </div>
                <!-- / Page content -->
            </div>
        </div>
        <!-- Layout inner -->
    </div>
    <!-- / Layout wrapper -->
</template>

<script>
    import NavMenu from './nav-menu'
    import NavBar from './nav-bar'

    export default {
      components: {
        'nav-menu': NavMenu,
        'nav-bar' : NavBar
      },

      data () {
        return {}
      }
    }
</script>

<style>
</style>

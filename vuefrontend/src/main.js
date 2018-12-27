// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
// import axios from 'axios'
import HelloWorld from './components/HelloWorld.vue'
Vue.config.productionTip = false

/* eslint-disable no-new */
// new Vue({
//   el: '#app',
//   data () {
//     return {
//       info: null
//     }
//   },
//   mounted () {
//     axios
//       .get('http://localhost:1600/api/posts/')
//       .then(response => (this.info = response.data))
//   }
// })
// new Vue({
//   el: '#heading',
//   data () {
//     return {
//       headings: null
//     }
//   },
//   mounted () {
//     axios
//       .get('http://localhost:1600/api/headings')
//       .then(response => (this.headings = response.data))
//   }
// })
// new Vue({
//   data () {
//     return {
//       user: {
//         Username: '',
//         Content: ''
//       }
//     }
//   },
//   methods: {
//     handleSubmit () {
//       axios
//         .put('http://localhost:1600/api/headings', this.user)
//     }
//   }
// })

new HelloWorld({
  el: '#app'
})

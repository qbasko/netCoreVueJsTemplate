<template>
    <div>
        <h1>Hello, world!</h1>
        <p>Welcome to your new single-page application, built with: </p>
        <ul>
            <li><a href="https://get.asp.net/"><icon :icon="['fab', 'microsoft']"/> ASP.NET Core</a> and <a href="https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx">C#</a>                    for cross-platform server-side code</li>
            <li><a href="https://vuejs.org/"><icon :icon="['fab', 'vuejs']"/> Vue.js</a> for client-side code</li>
            <li><a href="https://webpack.js.org/">Webpack</a> for building and bundling client-side resources</li>
            <li><a href="http://getbootstrap.com/">Bootstrap</a> for layout and styling</li>
            <li><a href="http://jquery.com/">JQuery</a> for Bootstrap components</li>
            <li><a href="https://fontawesome.com"><icon :icon="['fab', 'font-awesome']"/> Font Awesome</a> (Free) for the icons</li>
            <li><a href="api/SampleData/WeatherForecasts">API sample data</a> from the dotnet controller</li>
        </ul>

        <br><br>
    </div>
</template>

<script>
export default {
  data () {
    return {}
  }
}
</script>

<style>
</style>

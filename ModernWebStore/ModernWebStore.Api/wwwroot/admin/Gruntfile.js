module.exports = function(grunt) {
    grunt.initConfig({
        cssmin: {
            sitecss: {
                files: {
                    'wwwroot/dist/assets/css/styles-1.0.0.min.css': [
                        'bower_components/bootswatch/paper/bootstrap.css',
                        'bower_components/animate.css/animate.css',
                        'bower_components/font-awesome/css/font-awesome.css'
                    ]
                }
            }
        },
        uglify: {
            options: {
                compress: true
            },
            applib: {
                src: [
                    'bower_components/jquery/dist/jquery.js',
                    'bower_components/bootstrap/dist/js/bootstrap.js',
                    'bower_components/angular/angular.js',
                    'bower_components/angular-route/angular-route.js',
                    'app/app.js'
                ],
                dest: 'wwwroot/dist/assets/js/scripts-1.0.0.min.js'
            }
        },
        copy: {
            main: {
                files: [{
                    expand: true,
                    cwd: 'bower_components/font-awesome/fonts/',
                    src: '**',
                    dest: 'wwwroot/dist/assets/font',
                    flatten: false,
                }],
                files: [{
                    expand: true,
                    cwd: 'wwwroot/dev/assets/imgs',
                    src: '**',
                    dest: 'wwwroot/dist/assets/imgs',
                    flatten: false,
                }]
            }
        },
        htmlmin: {
            dist: {
                options: {
                    removeComments: true,
                    collapseWhitespace: true
                },
                files: {
                    'wwwroot/dist/pages/shared/headbar.html': 'wwwroot/dev/pages/shared/headbar.html'
                }
            }
        }
    });

    grunt.registerTask("dist", [
        'cssmin',
        'uglify',
        'copy',
        'htmlmin'
    ]);

    grunt.loadNpmTasks('grunt-contrib-cssmin');
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-htmlmin');
};
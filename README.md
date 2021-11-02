# svg_single_path_shortener
Takes a joined path, trims the numbers down, removes excess zeros, sometimes cuts the svg in half.


Basically input something nasty like the following (16,374 chars) which gets reduced to 9,706 charactres
m 18.404297,-0.10546875 c -1.077342,-0.13033752 -1.98054,0.38273278 -2.4375,1.12890625 -0.45696,0.7461735 -0.464673,1.7370596 0.222656,2.5175781 l 0.484375,0.5507813 -5.820312,4.1835937 C 9.2226069,9.448322 7.7157906,10.511502 6.6015625,11.279297 6.0444485,11.663194 5.5857183,11.973157 5.2597656,12.185547 5.0967893,12.291742 4.9657209,12.374139 4.875,12.427734 c -0.044345,0.0262 -0.078745,0.04525 -0.1015625,0.05664 -0.00797,-0.0033 -0.029456,-0.0082 -0.070312,-0.03125 C 4.6529982,12.424883 4.5903242,12.383434 4.5195312,12.332031 4.3779453,12.229226 4.2073879,12.088408 4.0488281,11.9375 2.9586552,10.899935 1.2812176,10.991544 0.38085938,12.144531 c -0.24273983,0.310852 -0.42307307,0.582851 -0.484375,0.900391 -0.0613019,0.31754 0.0046981,0.66336 0.22070312,1.101562 0.43200999,0.876405 1.4592751,2.162015 3.4121094,4.539063 l 3.7421875,4.554687 1.7988281,0.25586 1.6679685,0.238281 0.595703,2.144531 c 0.200994,0.723555 0.398915,1.306789 0.589844,1.734375 0.19093,0.427586 0.357245,0.705428 0.578125,0.81836 0.163951,0.08382 0.46074,0.164003 0.841797,0.248047 0.381057,0.08404 0.83716,0.164384 1.279297,0.222656 l 1.509765,0.199218 0.435547,1.69336 c 0.126614,0.491035 0.223722,0.861813 0.341797,1.158203 0.118076,0.29639 0.261924,0.522221 0.476563,0.689453 0.429278,0.334464 1.08739,0.434198 2.359375,0.640625 l 1.449218,0.234375 0.394532,1.447266 c 0.288111,1.056 0.481256,1.652067 0.902344,2.041015 0.421087,0.388948 1.030102,0.532781 2.103515,0.734375 l 1.759766,0.330078 0.40039,1.449219 c 0.116295,0.421924 0.247321,0.84161 0.365235,1.181641 0.117914,0.340031 0.209368,0.585459 0.294922,0.71289 0.05979,0.08906 0.153978,0.145132 0.27539,0.201172 0.121412,0.05604 0.274003,0.108935 0.458985,0.158204 0.369963,0.09854 0.867112,0.185027 1.46875,0.257812 l 1.802734,0.21875 0.460937,1.720703 c 0.276488,1.031887 0.489866,1.634031 0.955079,2.013672 0.465212,0.379641 1.138005,0.504334 2.296875,0.644531 L 36.544922,46.800781 37,48.496094 c 0.131618,0.491214 0.232359,0.863628 0.353516,1.160156 0.121156,0.296528 0.26666,0.520225 0.482422,0.6875 0.431523,0.33455 1.089902,0.434606 2.359374,0.640625 l 1.449219,0.236328 0.394531,1.445313 c 0.115385,0.422921 0.252072,0.848025 0.38086,1.193359 0.128788,0.345334 0.235715,0.599219 0.34375,0.734375 0.06868,0.08592 0.169041,0.138334 0.30664,0.203125 0.1376,0.06479 0.31182,0.132411 0.513672,0.199219 0.403706,0.133614 0.916817,0.267364 1.453125,0.371094 l 1.832032,0.353515 0.273437,1.212891 c 0.263044,1.173675 0.413514,1.805868 0.8125,2.193359 0.398986,0.387491 0.993838,0.472813 2.074219,0.603516 l 1.814453,0.21875 0.353516,1.375 c 0.256488,0.996395 0.476868,1.658674 0.730468,2.097656 0.2536,0.438982 0.561934,0.657452 0.939454,0.703125 0.100556,0.01216 0.192152,-0.01982 0.314453,-0.06641 0.1223,-0.04659 0.26906,-0.114129 0.439453,-0.203125 0.340785,-0.177993 0.776545,-0.437762 1.273437,-0.751953 0.993786,-0.628382 2.234517,-1.481264 3.449219,-2.359375 1.214702,-0.878112 2.402991,-1.78058 3.287109,-2.509766 0.44206,-0.364593 0.806323,-0.684274 1.064453,-0.939453 0.129066,-0.12759 0.231763,-0.238449 0.304688,-0.333984 0.07292,-0.09554 0.129247,-0.16405 0.125,-0.279297 -0.0015,-0.03956 -0.0089,-0.05114 -0.01563,-0.06641 -0.0067,-0.01527 -0.01438,-0.03097 -0.02344,-0.04687 -0.01812,-0.0318 -0.04302,-0.06871 -0.07422,-0.115234 -0.0624,-0.09304 -0.151638,-0.218976 -0.269531,-0.378906 C 63.5064,55.754358 63.161166,55.300691 62.716797,54.728516 61.828058,53.584165 60.543686,51.963 58.960938,49.984375 55.79544,46.027124 51.432028,40.639358 46.634766,34.775391 39.251387,25.750274 34.890939,20.389777 32.380859,17.207031 31.12582,15.615658 30.334516,14.568956 29.859375,13.882812 c -0.23757,-0.343071 -0.396453,-0.595403 -0.492187,-0.777343 -0.09573,-0.181941 -0.122275,-0.296383 -0.121094,-0.332031 0.0124,-0.374437 -0.223455,-0.841933 -0.94336,-1.833985 C 27.58283,9.9474008 26.364095,8.4293395 24.357422,5.9921875 22.030221,3.1657512 20.797874,1.6813196 20.021484,0.88085938 19.63329,0.48062926 19.35704,0.25012037 19.109375,0.109375 18.86171,-0.03137037 18.644476,-0.07641241 18.404297,-0.10546875 Z m -0.03125,0.25 c 0.229107,0.0277168 0.397516,0.0620866 0.611328,0.18359375 0.213812,0.12150717 0.475158,0.33641347 0.855469,0.7285156 0.760622,0.7842043 1.995301,2.2695539 4.322265,5.0957032 2.005909,2.4362243 3.225399,3.9522952 3.9375,4.9335942 0.712101,0.981298 0.900957,1.426676 0.892579,1.679687 -0.0042,0.126021 0.04832,0.259337 0.152343,0.457031 0.104024,0.197695 0.267076,0.45509 0.507813,0.802735 0.481473,0.695288 1.274871,1.744819 2.53125,3.33789 2.512757,3.186142 6.872304,8.546934 14.255859,17.572266 4.796777,5.863374 9.159584,11.250858 12.324219,15.207031 1.582317,1.978087 2.866542,3.597654 3.753906,4.740234 0.443682,0.571291 0.788085,1.023222 1.021484,1.339844 0.1167,0.158311 0.205148,0.283832 0.263672,0.371094 0.02926,0.04363 0.05165,0.07715 0.06445,0.09961 0.0011,0.0019 10e-4,0.0022 0.002,0.0039 -0.0024,-0.01544 -0.01335,0.03475 -0.07031,0.109375 -0.06077,0.07962 -0.155088,0.185805 -0.279297,0.308593 -0.248417,0.245578 -0.612048,0.563933 -1.050781,0.925782 -0.877465,0.723698 -2.060092,1.62428 -3.271484,2.5 -1.211392,0.875719 -2.450636,1.725603 -3.4375,2.349609 -0.493432,0.312003 -0.925798,0.567842 -1.25586,0.740234 -0.165031,0.0862 -0.30487,0.152511 -0.412109,0.19336 -0.107239,0.04085 -0.187603,0.04952 -0.193359,0.04883 -0.305974,-0.03702 -0.522318,-0.180625 -0.751954,-0.578125 -0.229636,-0.3975 -0.450617,-1.046637 -0.705078,-2.035156 l -0.39653,-1.541012 -1.986328,-0.240234 c -1.077272,-0.130327 -1.607961,-0.222642 -1.927735,-0.533204 -0.319774,-0.310561 -0.479703,-0.897183 -0.742187,-2.068359 l -0.308594,-1.373047 -1.99414,-0.384765 C 44.5597,55.017358 44.05453,54.885092 43.664062,54.755859 c -0.195233,-0.06462 -0.362734,-0.127351 -0.486328,-0.185547 -0.123593,-0.05819 -0.206048,-0.121319 -0.216796,-0.134765 -0.04927,-0.06164 -0.179072,-0.327235 -0.304688,-0.664063 -0.125616,-0.336827 -0.259745,-0.756588 -0.373047,-1.171875 l -0.4375,-1.601562 -1.611328,-0.261719 C 38.965454,50.530399 38.339003,50.414924 37.990234,50.144531 37.81585,50.009335 37.699364,49.833374 37.587891,49.560547 37.476418,49.287719 37.375642,48.92047 37.244141,48.429688 L 36.746094,46.570312 35.164062,46.378906 C 34.012209,46.239558 33.388046,46.108918 32.996094,45.789062 32.604142,45.469207 32.401253,44.928018 32.126953,43.904297 L 31.621094,42.019531 29.648438,41.78125 c -0.593892,-0.07185 -1.081898,-0.158282 -1.433594,-0.251953 -0.175848,-0.04684 -0.31684,-0.0959 -0.417969,-0.142578 -0.101129,-0.04668 -0.158674,-0.09653 -0.169922,-0.113281 -0.03784,-0.05636 -0.151841,-0.320544 -0.267578,-0.654297 -0.115737,-0.333753 -0.246507,-0.751391 -0.361328,-1.167969 l -0.441406,-1.59961 -1.914063,-0.359374 c -1.068189,-0.200613 -1.62525,-0.345573 -1.978516,-0.671876 -0.353265,-0.326302 -0.543359,-0.870979 -0.830078,-1.921874 l -0.4375,-1.603516 -1.609375,-0.261719 C 18.515618,32.826856 17.888707,32.712735 17.542969,32.443359 17.3701,32.308672 17.253042,32.133709 17.144531,31.861328 17.03602,31.588947 16.939013,31.221113 16.8125,30.730469 L 16.333984,28.873047 14.65625,28.652344 c -0.434371,-0.05725 -0.884832,-0.136488 -1.257812,-0.21875 -0.372981,-0.08226 -0.677655,-0.173598 -0.78125,-0.226563 -0.09386,-0.04799 -0.280259,-0.288262 -0.462891,-0.697265 -0.182632,-0.409004 -0.37927,-0.983361 -0.578125,-1.699219 L 10.9375,23.507812 9.1054688,23.246094 7.4042969,23.003906 3.7246094,18.525391 C 1.7726659,16.149427 0.74823663,14.855725 0.34375,14.035156 0.14150668,13.624872 0.09399477,13.343455 0.14257812,13.091797 c 0.0485834,-0.251659 0.20151205,-0.490764 0.4375,-0.792969 C 1.3915382,11.259683 2.8827616,11.176737 3.875,12.121094 c 0.166659,0.158616 0.3433995,0.305145 0.4960938,0.416015 0.076347,0.05544 0.1463428,0.101427 0.2089843,0.136719 0.062642,0.03529 0.1118842,0.06211 0.1796875,0.07031 0.051335,0.0062 0.06014,-0.0059 0.076172,-0.01172 0.016032,-0.0059 0.030514,-0.01338 0.046875,-0.02148 0.032722,-0.01621 0.072762,-0.03785 0.1210937,-0.06641 0.096664,-0.05711 0.2279293,-0.138809 0.3925782,-0.246093 C 5.7257822,12.183865 6.185993,11.872888 6.7441407,11.488278 7.8604361,10.719062 9.3698952,9.6542266 11.001953,8.4804688 L 17.046875,4.1328125 16.378906,3.3730469 C 15.761077,2.6714514 15.774772,1.8186758 16.181641,1.1542969 16.588509,0.489918 17.390256,0.02563264 18.373047,0.14453125 Z m 9.07813,14.91992175 -5.88086,4.193359 c -1.589937,1.133866 -3.103281,2.187803 -4.259765,2.970704 -0.578242,0.39145 -1.067511,0.715085 -1.431641,0.947265 -0.182065,0.116091 -0.333083,0.208667 -0.447265,0.275391 -0.114182,0.06672 -0.200487,0.108546 -0.214844,0.113281 -0.301084,0.09929 -0.885946,0.154188 -1.240235,0.111328 -0.234724,-0.0284 -0.412466,-0.02878 -0.552734,0.02539 -0.07013,0.02708 -0.135317,0.07352 -0.171875,0.142578 -0.03656,0.06906 -0.03754,0.149644 -0.01758,0.222656 0.04812,0.175915 0.222401,0.804072 0.388672,1.398438 l 0.326172,1.162109 2,0.242188 c 0.932808,0.112849 1.413576,0.180519 1.675781,0.298828 0.131102,0.05915 0.210186,0.126018 0.287109,0.228515 0.07692,0.102497 0.147418,0.244235 0.240235,0.439454 0.200327,0.42134 0.453034,1.283944 0.544922,1.875 l 0.185546,1.197265 1.453126,0.175781 c 1.336045,0.161632 2.029445,0.280231 2.435546,0.574219 0.406102,0.293988 0.58354,0.792317 0.865235,1.800781 l 0.527343,1.890625 2.115235,0.382813 1.960937,0.355469 0.498047,1.767578 0.542969,1.925781 1.570312,0.189453 c 1.159863,0.140317 1.791849,0.274803 2.1875,0.597656 0.395652,0.322854 0.598385,0.864994 0.861329,1.884766 l 0.484375,1.875 1.972656,0.238281 c 0.593986,0.07186 1.083815,0.160232 1.435547,0.253906 0.175866,0.04684 0.316833,0.09395 0.417969,0.140626 0.101135,0.04668 0.158674,0.09653 0.169921,0.113281 0.03784,0.05636 0.15184,0.320543 0.267579,0.654297 0.115738,0.333753 0.244549,0.751389 0.359374,1.167968 l 0.441407,1.59961 1.916015,0.361328 c 1.068195,0.200614 1.625252,0.345572 1.978516,0.671875 0.353264,0.326302 0.543379,0.870986 0.830078,1.921875 l 0.435547,1.599609 c 2.863468,0.756786 3.74045,-0.506449 4.560547,2.503907 l 0.521484,1.923828 1.753906,0.21289 c 0.454159,0.05494 0.917958,0.136113 1.294922,0.22461 0.376965,0.0885 0.679783,0.196698 0.759766,0.25 0.07277,0.04849 0.223862,0.255067 0.353516,0.529296 0.129654,0.27423 0.251973,0.617069 0.332031,0.957032 0.08308,0.352806 0.17483,0.674753 0.257812,0.914062 0.04149,0.119655 0.08032,0.218128 0.117188,0.292969 0.01843,0.03742 0.03712,0.06896 0.05859,0.09766 0.02147,0.02869 0.04058,0.07034 0.121093,0.08008 6.34e-4,7.7e-5 0.01861,4.17e-4 0.02539,0 0.0068,-4.17e-4 0.01078,-0.0011 0.01563,-0.002 0.0097,-0.0017 0.01699,-0.0038 0.02344,-0.0059 0.01289,-0.0041 0.02435,-0.0087 0.03516,-0.01367 0.0216,-0.0099 0.04435,-0.02129 0.07227,-0.03711 0.05583,-0.03164 0.129827,-0.07676 0.220703,-0.134766 0.181753,-0.116004 0.431121,-0.284866 0.734376,-0.492188 0.606509,-0.414642 1.422338,-0.987879 2.300781,-1.621093 L 61.46875,56.351562 44.455078,35.701172 Z m -0.04492,0.341797 16.853516,20.455078 16.84375,20.441406 -3.082032,2.222657 c -0.877013,0.632184 -1.690962,1.206241 -2.294922,1.61914 -0.301979,0.20645 -0.552797,0.372929 -0.730468,0.486328 -0.08725,0.05569 -0.156434,0.09732 -0.205078,0.125 -0.0018,-0.0035 -0.002,-0.004 -0.0039,-0.0078 -0.02877,-0.0584 -0.06602,-0.149919 -0.105468,-0.263672 -0.07889,-0.227505 -0.168603,-0.544976 -0.25,-0.890625 -0.08442,-0.358491 -0.211365,-0.715412 -0.34961,-1.007812 -0.138245,-0.292401 -0.274137,-0.518092 -0.443359,-0.63086 -0.161999,-0.107959 -0.454235,-0.192219 -0.841797,-0.283203 -0.387562,-0.09098 -0.85843,-0.176308 -1.322266,-0.232422 L 49.890639,57.248059 49.412123,55.488293 C 48.880777,52.60055 47.469819,53.31362 44.810561,52.832043 L 44.416016,51.384766 C 44.127924,50.328771 43.934759,49.732699 43.513672,49.34375 43.092585,48.954801 42.485528,48.810971 41.412109,48.609375 l -1.761718,-0.332031 -0.398438,-1.447266 c -0.116299,-0.421924 -0.247319,-0.843563 -0.365234,-1.183594 -0.117916,-0.34003 -0.211322,-0.585459 -0.296875,-0.71289 -0.05979,-0.08906 -0.152018,-0.145131 -0.273438,-0.201172 -0.12142,-0.05604 -0.273985,-0.10698 -0.458984,-0.15625 -0.369999,-0.09854 -0.867019,-0.186969 -1.46875,-0.259766 l -1.802734,-0.21875 -0.441407,-1.707031 c -0.265229,-1.028636 -0.476502,-1.635027 -0.945312,-2.017578 -0.46881,-0.382551 -1.151095,-0.511131 -2.31836,-0.652344 l -1.402343,-0.169922 -0.498047,-1.763672 -0.539063,-1.917968 -2.117187,-0.384766 -1.958985,-0.355469 -0.486328,-1.738281 c -0.283068,-1.013381 -0.472167,-1.585079 -0.958984,-1.9375 -0.486817,-0.352421 -1.213614,-0.457137 -2.552734,-0.619141 l -1.263672,-0.152343 -0.158204,-1.009766 c -0.09672,-0.622111 -0.34304,-1.477672 -0.564453,-1.943359 -0.09373,-0.197136 -0.169643,-0.351929 -0.267578,-0.482422 -0.09793,-0.130494 -0.220452,-0.232501 -0.384765,-0.306641 -0.328627,-0.148279 -0.814338,-0.207354 -1.748047,-0.320312 L 14.146484,26.396484 13.867188,25.398438 C 13.700984,24.804312 13.525936,24.173362 13.478516,24 c -0.0082,-0.03015 -0.0053,-0.03644 -0.0039,-0.03906 0.0014,-0.0026 0.007,-0.01106 0.03906,-0.02344 0.06409,-0.02475 0.216582,-0.03774 0.43164,-0.01172 0.407132,0.04925 0.989495,-0.0017 1.351563,-0.121093 0.06853,-0.0226 0.142826,-0.06529 0.261719,-0.134766 0.118893,-0.06948 0.273303,-0.164099 0.457031,-0.28125 0.367457,-0.234302 0.856118,-0.558918 1.435547,-0.951172 1.158858,-0.784508 2.674204,-1.839686 4.265625,-2.974609 z M 0.48101314,12.221676 C 1.3369223,11.12561 2.921176,11.037837 3.9623817,12.028798 c 0.3252188,0.309525 0.6905311,0.574777 0.8118083,0.589449 0.1212773,0.01468 2.8902024,-1.893344 6.153169,-4.2400332 l 5.932665,-4.2667104 -0.57639,-0.6545361 c -1.305159,-1.482114 0.04501,-3.68677976 2.105143,-3.43754363 0.938573,0.11354634 1.216227,0.39980942 5.870393,6.05239503 4.012582,4.8733763 4.880691,6.0696663 4.859913,6.6971143 -0.02142,0.646678 2.651498,4.035889 17.418431,22.086338 9.594039,11.727341 17.452137,21.550901 17.462432,21.830135 0.02576,0.699093 -9.266244,7.416316 -10.116745,7.313424 -0.683493,-0.08269 -1.052744,-0.72185 -1.563693,-2.706765 L 51.944276,59.834361 50.043805,59.604447 C 47.886152,59.343418 47.790222,59.250253 47.264694,56.905402 L 46.974988,55.612806 45.061953,55.242795 C 43.999407,55.037283 43.021767,54.713712 42.862903,54.514976 42.705599,54.318182 42.389787,53.471361 42.1611,52.633153 l -0.415799,-1.524015 -1.53045,-0.248374 C 37.676458,50.448816 37.648189,50.426901 37.12195,48.462907 L 36.645596,46.685095 35.149465,46.504096 C 32.838742,46.22455 32.555167,45.993134 32.00438,43.937526 l -0.482898,-1.802237 -1.887787,-0.22838 c -1.195529,-0.144633 -1.970047,-0.350919 -2.112121,-0.562544 -0.12339,-0.183789 -0.41344,-1.020211 -0.644555,-1.858713 L 26.456788,37.961101 24.619112,37.615973 C 22.477509,37.213766 22.28702,37.037817 21.71219,34.930921 L 21.2964,33.406906 19.76594,33.158532 C 17.222464,32.745757 17.197295,32.726145 16.691043,30.762786 L 16.233236,28.987285 14.639595,28.777222 C 13.763087,28.661702 12.82704,28.455245 12.559494,28.318458 12.244757,28.15754 11.854927,27.284526 11.455078,25.845113 L 10.837104,23.62047 9.0875814,23.371033 7.3380583,23.121595 3.6276675,18.605187 C -0.27711028,13.852175 -0.47644241,13.447789 0.48101314,12.221676 Z m 13.26399086,13.210139 0.302251,1.080444 1.918059,0.232044 c 1.866517,0.225808 1.928375,0.253726 2.301465,1.038435 0.21087,0.443514 0.460561,1.302684 0.554863,1.909267 l 0.171468,1.102876 1.35838,0.164334 c 2.675166,0.323636 2.841038,0.443714 3.405801,2.465559 l 0.506952,1.814889 2.038162,0.369383 2.038173,0.369382 0.519388,1.843572 0.519389,1.84357 1.487238,0.179924 c 2.327127,0.28153 2.628401,0.52737 3.156574,2.575778 l 0.462032,1.791894 1.888034,0.228409 c 1.195717,0.144656 1.970284,0.350941 2.112358,0.562573 0.12339,0.18379 0.41344,1.020211 0.644565,1.858714 l 0.420221,1.524551 1.837676,0.345127 c 2.141613,0.40221 2.332112,0.578166 2.906903,2.685049 l 0.415779,1.524013 2.040245,0.369635 2.040255,0.369635 0.500053,1.841232 0.500063,1.841232 1.669069,0.201921 c 0.917994,0.111057 1.86706,0.333859 2.109042,0.49512 0.241992,0.161261 0.574554,0.864664 0.739034,1.563118 0.16448,0.698455 0.365421,1.27795 0.446545,1.287764 0.08114,0.0098 1.58378,-1.017483 3.339236,-2.282882 l 3.191742,-2.300723 -16.929077,-20.545813 -16.929087,-20.54581 -5.784294,4.12507 c -3.181359,2.268788 -6.055581,4.214537 -6.387146,4.323886 -0.331576,0.109348 -0.914342,0.161132 -1.295052,0.115076 -0.449783,-0.05442 -0.661799,0.02746 -0.605399,0.233782 0.04777,0.174638 0.222803,0.803724 0.38904,1.39797 z


And it will clean it up to look like 


M 4.872,-.022 C 4.587,-.056 4.349,.08 4.228,.277 4.107,.474 4.105,.736 4.287,.942 L 4.415,1.088 2.876,2.194 C 2.445,2.504 2.046,2.785 1.752,2.988 1.605,3.09 1.483,3.172 1.397,3.228 c -.043,.028 -.078,.05 -.102,.064 -.012,.007 -.021,.012 -.027,.015 -.002,-.001 -.008,-.002 -.019,-.008 -.013,-.007 -.03,-.018 -.049,-.032 C 1.164,3.239 1.119,3.202 1.077,3.162 .789,2.888 .345,2.912 .107,3.217 c -.064,.082 -.112,.154 -.128,.238 -.016,.084 .001,.175 .058,.291 .114,.232 .386,.572 .902,1.2 l .989,1.204 .476,.068 .441,.063 .157,.567 c .053,.191 .105,.345 .156,.459 .05,.113 .094,.187 .153,.216 .043,.022 .122,.043 .223,.066 .101,.022 .221,.043 .338,.059 l .399,.053 .115,.448 c .033,.13 .059,.228 .09,.306 .031,.078 .069,.138 .126,.182 .113,.088 .287,.115 .624,.169 l .383,.062 .104,.383 c .076,.279 .127,.437 .239,.54 .111,.103 .272,.141 .556,.194 l .465,.087 .106,.383 c .031,.112 .065,.223 .097,.312 .031,.09 .055,.155 .078,.188 .016,.024 .041,.038 .073,.053 .032,.015 .072,.029 .121,.042 .098,.026 .229,.049 .388,.068 l .477,.058 .122,.455 c .073,.273 .13,.432 .253,.532 .123,.1 .301,.133 .607,.17 l .373,.045 .12,.448 c .035,.13 .061,.228 .093,.307 .032,.078 .071,.138 .128,.182 .114,.088 .288,.115 .624,.169 l .383,.062 .104,.382 c .031,.112 .067,.224 .101,.316 .034,.091 .062,.158 .091,.194 .018,.023 .045,.037 .081,.054 .036,.017 .082,.035 .136,.053 .107,.035 .242,.071 .384,.098 l .484,.093 .072,.321 c .07,.31 .109,.477 .215,.58 .105,.102 .263,.125 .548,.16 l .48,.058 .093,.364 c .068,.263 .126,.439 .193,.555 .067,.116 .149,.174 .248,.186 .027,.003 .051,-.005 .083,-.018 .032,-.012 .071,-.03 .116,-.054 .09,-.047 .205,-.116 .337,-.199 .263,-.166 .591,-.392 .912,-.624 .321,-.232 .635,-.471 .869,-.664 .117,-.096 .213,-.181 .281,-.248 .034,-.034 .061,-.063 .081,-.088 .019,-.025 .034,-.043 .033,-.074 -0,-.01 -.002,-.014 -.004,-.018 -.002,-.004 -.004,-.008 -.006,-.012 -.005,-.008 -.011,-.018 -.02,-.03 -.017,-.025 -.04,-.058 -.071,-.1 -.062,-.085 -.154,-.205 -.271,-.356 C 16.353,14.173 16.013,13.744 15.595,13.221 14.758,12.175 13.604,10.75 12.336,9.2 10.384,6.814 9.231,5.397 8.567,4.555 8.236,4.135 8.026,3.858 7.901,3.677 7.838,3.586 7.796,3.519 7.771,3.471 7.745,3.423 7.738,3.393 7.739,3.383 7.742,3.284 7.68,3.161 7.489,2.898 7.299,2.636 6.977,2.235 6.446,1.59 5.831,.843 5.505,.451 5.3,.239 5.197,.133 5.124,.072 5.059,.035 4.993,-.002 4.936,-.014 4.872,-.022 Z m -.008,.066 c .061,.007 .105,.016 .162,.049 .057,.032 .126,.089 .226,.193 .201,.207 .528,.6 1.143,1.347 .53,.644 .853,1.045 1.041,1.304 .188,.259 .238,.377 .236,.444 -.001,.033 .013,.069 .04,.121 .028,.052 .071,.12 .134,.212 .127,.184 .337,.461 .669,.882 .664,.842 1.817,2.26 3.769,4.646 1.268,1.55 2.422,2.975 3.258,4.02 .418,.523 .758,.951 .992,1.253 .117,.151 .208,.271 .27,.354 .031,.042 .054,.075 .07,.098 .008,.012 .014,.02 .017,.026 0,.001 0,.001 .001,.001 -.001,-.004 -.004,.009 -.019,.029 -.016,.021 -.041,.049 -.074,.082 -.066,.065 -.162,.149 -.278,.245 -.232,.191 -.545,.429 -.865,.661 -.32,.232 -.648,.456 -.909,.621 -.13,.082 -.245,.15 -.332,.196 -.044,.023 -.081,.04 -.109,.051 -.028,.011 -.05,.013 -.051,.013 -.081,-.01 -.138,-.048 -.199,-.153 -.061,-.105 -.119,-.277 -.186,-.538 l -.105,-.407 -.525,-.064 c -.285,-.034 -.425,-.059 -.51,-.141 -.085,-.082 -.127,-.237 -.196,-.547 l -.082,-.363 -.527,-.102 c -.139,-.027 -.273,-.062 -.376,-.096 -.052,-.017 -.096,-.034 -.129,-.049 -.033,-.015 -.054,-.032 -.057,-.036 -.013,-.016 -.047,-.087 -.081,-.176 -.033,-.089 -.069,-.2 -.099,-.31 l -.116,-.423 -.426,-.069 c -.335,-.054 -.501,-.085 -.593,-.156 -.046,-.036 -.077,-.082 -.106,-.154 -.029,-.072 -.056,-.169 -.091,-.299 L 9.721,12.319 9.303,12.268 C 8.999,12.231 8.834,12.197 8.73,12.112 8.626,12.027 8.573,11.884 8.5,11.614 l -.134,-.498 -.522,-.063 c -.157,-.019 -.286,-.042 -.379,-.067 -.046,-.012 -.084,-.025 -.111,-.038 -.027,-.012 -.042,-.026 -.045,-.03 -.01,-.015 -.04,-.085 -.071,-.173 -.031,-.088 -.065,-.199 -.096,-.309 L 7.028,10.013 6.522,9.918 C 6.239,9.865 6.092,9.827 5.998,9.741 5.905,9.655 5.855,9.511 5.779,9.233 L 5.663,8.809 5.238,8.74 C 4.902,8.685 4.736,8.655 4.645,8.584 4.599,8.548 4.568,8.502 4.539,8.43 4.511,8.358 4.485,8.26 4.451,8.131 L 4.325,7.64 3.881,7.581 C 3.767,7.566 3.647,7.545 3.549,7.524 3.45,7.502 3.37,7.478 3.342,7.464 3.317,7.451 3.268,7.387 3.22,7.279 3.172,7.171 3.12,7.019 3.067,6.83 L 2.898,6.221 2.414,6.152 1.964,6.088 .991,4.904 C .475,4.276 .204,3.934 .097,3.717 .044,3.608 .031,3.534 .044,3.467 .057,3.401 .097,3.338 .16,3.258 .374,2.983 .769,2.961 1.031,3.211 c .044,.042 .091,.081 .131,.11 .02,.015 .039,.027 .055,.036 .017,.009 .03,.016 .048,.019 .014,.002 .016,-.002 .02,-.003 .004,-.002 .008,-.004 .012,-.006 .009,-.004 .019,-.01 .032,-.018 C 1.355,3.334 1.39,3.313 1.433,3.284 1.52,3.227 1.642,3.145 1.79,3.044 2.085,2.84 2.484,2.559 2.915,2.248 L 4.513,1.099 4.337,.898 C 4.173,.713 4.177,.487 4.285,.311 4.392,.136 4.604,.013 4.864,.044 Z M 7.264,3.989 5.709,5.098 c -.42,.3 -.82,.578 -1.126,.785 -.153,.103 -.282,.189 -.378,.25 -.048,.031 -.088,.055 -.118,.073 -.03,.018 -.053,.029 -.057,.03 -.08,.026 -.234,.041 -.328,.029 -.062,-.008 -.109,-.008 -.146,.007 -.019,.007 -.036,.019 -.045,.038 -.01,.018 -.01,.04 -.005,.059 .013,.047 .059,.213 .103,.37 l .086,.307 .529,.064 c .247,.03 .374,.048 .443,.079 .035,.016 .056,.033 .076,.06 .02,.027 .039,.065 .064,.116 .053,.111 .12,.339 .144,.496 l .049,.317 .384,.046 c .353,.043 .537,.074 .644,.152 .107,.078 .154,.209 .229,.476 l .139,.5 .559,.101 .518,.094 .132,.467 .144,.509 .415,.05 c .307,.037 .474,.073 .578,.158 .105,.085 .158,.229 .228,.498 l .128,.496 .522,.063 c .157,.019 .287,.042 .38,.067 .046,.012 .084,.025 .111,.037 .027,.012 .042,.026 .045,.03 .01,.015 .04,.085 .071,.173 .031,.088 .065,.199 .095,.309 l .117,.423 .507,.096 c .282,.053 .43,.091 .523,.178 .093,.086 .144,.23 .219,.508 l .115,.423 c .757,.2 .989,-.134 1.206,.662 l .138,.509 .464,.056 c .12,.015 .243,.036 .342,.059 .1,.023 .18,.052 .201,.066 .019,.013 .059,.067 .093,.14 .034,.073 .067,.163 .088,.253 .022,.093 .046,.178 .068,.242 .011,.032 .021,.058 .031,.077 .005,.01 .01,.018 .015,.026 .006,.008 .011,.019 .032,.021 0,0 .005,0 .007,0 .002,-0 .003,-0 .004,-.001 .003,-0 .005,-.001 .006,-.002 .003,-.001 .006,-.002 .009,-.004 .006,-.003 .012,-.006 .019,-.01 .015,-.008 .034,-.02 .058,-.036 .048,-.031 .114,-.075 .194,-.13 .16,-.11 .376,-.261 .608,-.429 l .873,-.629 -4.498,-5.46 z m -.012,.09 4.456,5.408 4.453,5.404 -.815,.588 c -.232,.167 -.447,.319 -.607,.428 -.08,.055 -.146,.099 -.193,.129 -.023,.015 -.041,.026 -.054,.033 -0,-.001 -.001,-.001 -.001,-.002 -.008,-.015 -.017,-.04 -.028,-.07 -.021,-.06 -.045,-.144 -.066,-.235 -.022,-.095 -.056,-.189 -.092,-.266 -.037,-.077 -.072,-.137 -.117,-.167 -.043,-.029 -.12,-.051 -.223,-.075 -.102,-.024 -.227,-.047 -.35,-.061 l -.419,-.051 -.127,-.465 c -.14,-.763 -.514,-.575 -1.217,-.702 l -.104,-.383 c -.076,-.279 -.127,-.437 -.239,-.54 -.111,-.103 -.272,-.141 -.556,-.194 l -.466,-.088 -.105,-.383 c -.031,-.112 -.065,-.223 -.097,-.313 -.031,-.09 -.056,-.155 -.078,-.188 -.016,-.024 -.04,-.038 -.072,-.053 -.032,-.015 -.072,-.028 -.121,-.041 -.098,-.026 -.229,-.049 -.388,-.069 L 9.15,11.665 9.034,11.213 C 8.964,10.942 8.908,10.781 8.784,10.68 8.66,10.579 8.479,10.545 8.171,10.508 L 7.8,10.463 7.668,9.996 7.526,9.489 6.966,9.388 6.448,9.294 6.32,8.834 C 6.245,8.566 6.195,8.415 6.066,8.322 5.937,8.229 5.745,8.201 5.391,8.158 L 5.057,8.118 5.015,7.851 C 4.99,7.686 4.925,7.46 4.866,7.337 4.841,7.285 4.821,7.244 4.795,7.21 4.769,7.175 4.737,7.148 4.694,7.129 4.607,7.089 4.478,7.074 4.231,7.044 L 3.747,6.985 3.673,6.721 C 3.629,6.564 3.583,6.397 3.57,6.351 c -.002,-.008 -.001,-.01 -.001,-.01 0,-.001 .002,-.003 .01,-.006 .017,-.007 .057,-.01 .114,-.003 .108,.013 .262,-0 .357,-.032 .018,-.006 .038,-.017 .069,-.036 .031,-.018 .072,-.043 .121,-.074 C 4.338,6.128 4.467,6.042 4.62,5.938 4.927,5.731 5.327,5.452 5.748,5.152 Z M .134,3.237 C .36,2.948 .779,2.924 1.054,3.186 1.14,3.268 1.237,3.338 1.269,3.342 1.301,3.346 2.033,2.842 2.896,2.221 L 4.464,1.093 4.312,.92 c -.345,-.392 .012,-.975 .557,-.909 .248,.03 .322,.106 1.552,1.6 1.061,1.288 1.29,1.605 1.285,1.771 -.006,.171 .701,1.067 4.605,5.839 2.536,3.1 4.614,5.698 4.617,5.771 .007,.185 -2.45,1.961 -2.675,1.934 -.181,-.022 -.278,-.191 -.413,-.716 l -.099,-.385 -.502,-.061 c -.57,-.069 -.596,-.094 -.735,-.714 l -.077,-.342 -.506,-.098 c -.281,-.054 -.539,-.14 -.581,-.192 -.042,-.052 -.125,-.276 -.186,-.498 l -.11,-.403 -.405,-.066 C 9.967,13.344 9.96,13.338 9.821,12.819 L 9.695,12.349 9.299,12.301 C 8.688,12.227 8.613,12.166 8.468,11.622 L 8.34,11.146 7.841,11.086 C 7.525,11.047 7.32,10.993 7.283,10.937 7.25,10.888 7.173,10.667 7.112,10.445 L 7.001,10.042 6.515,9.951 C 5.949,9.845 5.899,9.798 5.747,9.241 L 5.637,8.838 5.232,8.773 C 4.56,8.664 4.553,8.658 4.419,8.139 L 4.298,7.67 3.877,7.614 C 3.645,7.584 3.398,7.529 3.327,7.493 3.244,7.451 3.141,7.22 3.035,6.839 L 2.872,6.251 2.409,6.185 1.947,6.119 .966,4.925 C -.067,3.669 -.119,3.562 .134,3.237 Z M 3.64,6.73 3.72,7.016 4.227,7.077 c .493,.06 .51,.067 .608,.275 .056,.117 .122,.344 .147,.505 l .045,.292 .359,.043 c .707,.086 .751,.117 .9,.652 l .134,.48 .539,.098 .539,.098 .137,.487 .137,.487 .393,.048 c .615,.074 .695,.139 .835,.681 l .122,.474 .499,.06 c .316,.038 .521,.093 .558,.149 .033,.049 .109,.27 .17,.491 l .111,.403 .486,.091 c .566,.106 .617,.153 .769,.71 l .11,.403 .539,.098 .539,.098 .132,.487 .132,.487 .441,.053 c .243,.029 .494,.088 .558,.131 .064,.043 .152,.229 .195,.413 .043,.185 .097,.338 .118,.34 .021,.003 .419,-.269 .883,-.604 L 16.209,14.898 11.734,9.466 7.258,4.034 5.729,5.125 C 4.888,5.725 4.128,6.239 4.04,6.268 c -.088,.029 -.242,.043 -.342,.03 -.119,-.014 -.175,.007 -.16,.062 .013,.046 .059,.212 .103,.37 z

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Final_Project_Homekit_4.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HomekitDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<HomekitDbContext>>()))
            {
                // Look for any products.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                //Bridges    
                    new Product
                    {
                        ProductName = "Philips Hue White and Color Wireless Ambiance Starter Kit A19 E26",
                        ProductPrice = 149.95M,
                        Category = "Bridges",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName = "Philips Hue White Starter Kit A19 E26",
                        ProductPrice = 69.95M,
                        Category = "Bridges",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName = "Philips Hue White Ambiance A19 Starter Kit",
                        ProductPrice = 99.95M,
                        Category = "Bridges",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName = "Wemo Bridge",
                        ProductPrice = 29.95M,
                        Category = "Bridges",
                        Brand = new Brand{
                                BrandName = "Belkin"
                            },
                    },
                    new Product
                    {
                        ProductName = "Philips HUE HomeKit Upgrade Bridge (for Current HUE Bridge Users)",
                        ProductPrice = 59.95M,
                        Category = "Bridges",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },

                // Cameras
                    new Product
                    {
                        ProductName = "Logitech Circle 2 Indoor/Outdoor Weatherproof Wired Security Camera",
                        ProductPrice = 179.95M,
                        Category = "Cameras",
                        Brand = new Brand{
                                BrandName = "Logitech"
                            },
                    },
                    new Product
                    {
                        ProductName = "D-Link Omna 180 Cam HD Camera",
                        ProductPrice = 129.95M,
                        Category = "Cameras",
                        Brand = new Brand{
                                BrandName = "D-Link"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Arlo Baby 1080p HD Monitoring Camera by NETGEAR",
                        ProductPrice = 189.95M,
                        Category = "Cameras",
                        Brand = new Brand{
                                BrandName = "Netgear"
                            },
                    },

                // Lights & Bulbs
                    new Product
                    {
                        ProductName =  "Philips Hue White and Color Wireless Ambiance Starter Kit A19 E26",
                        ProductPrice = 149.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Nanoleaf Canvas Smarter Light Kit",
                        ProductPrice = 299.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Nanoleaf"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Nanoleaf Light Panel Smarter Kits - Rhythm Edition",
                        ProductPrice = 199.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Nanoleaf"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Philips Hue White Starter Kit A19 E26",
                        ProductPrice = 69.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Philips Hue White Ambiance A19 Starter Kit",
                        ProductPrice = 99.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Nanoleaf Remote",
                        ProductPrice = 49.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Nanoleaf"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Incipio CommandKit Smart Light Bulb Adapter with Dimming",
                        ProductPrice = 39.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Incipio"
                            },
                    },
                    new Product
                    {
                        ProductName =  "LIFX Mini White (2700K Warm) A19 E26 Wi-Fi Smart LED Light Bulb",
                        ProductPrice = 19.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "LIFX"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Philips Hue Ambiance White and Color Extension Bulb A19 E26",
                        ProductPrice = 49.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Philips Hue White and Color Ambiance LED Flood Light Bulb BR30",
                        ProductPrice = 49.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Philips Hue White Ambiance A19 Bulb",
                        ProductPrice = 29.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Philips Hue White Ambiance Wireless LED Flood Light BR30",
                        ProductPrice = 29.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Philips Hue Lightstrip Plus",
                        ProductPrice = 89.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Philips Hue White Extension Bulb A19 E26",
                        ProductPrice = 189.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName =  "LIFX Mini Color and White A19 E26 Wi-Fi Smart LED Light Bulb",
                        ProductPrice = 44.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "LIFX"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Philips Hue Lightstrip Plus Extension Set (3 ft./1 m)",
                        ProductPrice = 29.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Philips Hue Go",
                        ProductPrice = 79.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Philips Hue White and Color Ambiance LED Candle Bulb E12/B39",
                        ProductPrice = 49.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName =  "LIFX Multicolor A19 E26 Dimmable Wi-Fi Smart LED Light Bulb",
                        ProductPrice = 59.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "LIFX"
                            },
                    },
                    new Product
                    {
                        ProductName =  "LIFX Mini Day & Dusk (White to Amber Spectrum) A19 E26 Wi-Fi Smart LED Light Bulb",
                        ProductPrice = 29.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "LIFX"
                            },
                    },
                    new Product
                    {
                        ProductName =  "LIFX + Infrared Multicolor A19 E26 Dimmable Wi-Fi Smart LED Light Bulb",
                        ProductPrice = 79.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "LIFX"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Philips Hue White Ambiance LED Candle Bulb E12/B39",
                        ProductPrice = 29.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName =  "SYLVANIA SMART+ Bluetooth Soft White Filament Bulb A19",
                        ProductPrice = 34.95M,
                        Category = "Lights & Bulbs",
                        Brand = new Brand{
                                BrandName = "SYLVANIA"
                            },
                    },

                // Locks
                    new Product
                    {
                        ProductName =  "August Smart Lock Pro + Connect",
                        ProductPrice = 279.95M,
                        Category = "Locks",
                        Brand = new Brand{
                                BrandName = "August"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Yale Assure Lock SL with iM1",
                        ProductPrice = 199.95M,
                        Category = "Locks",
                        Brand = new Brand{
                                BrandName = "Yale"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Schlage Sense Smart Deadbolt with Century Trim",
                        ProductPrice = 229.95M,
                        Category = "Locks",
                        Brand = new Brand{
                                BrandName = "Schlage"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Schlage Sense Smart Deadbolt with Camelot Trim",
                        ProductPrice = 229.95M,
                        Category = "Locks",
                        Brand = new Brand{
                                BrandName = "Schlage"
                            },
                    },

                // Outlets
                    new Product
                    {
                        ProductName =  "Wemo Mini Smart Plug",
                        ProductPrice = 29.95M,
                        Category = "Outlets",
                        Brand = new Brand{
                                BrandName = "Belkin"
                            },
                    },
                    new Product
                    {
                        ProductName =  "iDevices Switch",
                        ProductPrice = 29.95M,
                        Category = "Outlets",
                        Brand = new Brand{
                                BrandName = "iDevices"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Incipio CommandKit Wireless Smart Outlet With Metering",
                        ProductPrice = 39.95M,
                        Category = "Outlets",
                        Brand = new Brand{
                                BrandName = "Incipio"
                            },
                    },
                    new Product
                    {
                        ProductName =  "iDevices Socket",
                        ProductPrice = 49.95M,
                        Category = "Outlets",
                        Brand = new Brand{
                                BrandName = "iDevices"
                            },
                    },
                    new Product
                    {
                        ProductName =  "iHome | control iSP6 SmartPlug",
                        ProductPrice = 39.95M,
                        Category = "Outlets",
                        Brand = new Brand{
                                BrandName = "iHome"
                            },
                    },
                    new Product
                    {
                        ProductName =  "iHome | control iSP8 SmartPlug with Remote Control",
                        ProductPrice = 49.95M,
                        Category = "Outlets",
                        Brand = new Brand{
                                BrandName = "iHome"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Eve Energy",
                        ProductPrice = 39.95M,
                        Category = "Outlets",
                        Brand = new Brand{
                                BrandName = "Eve"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Pure Gear PureSwitch Wireless Smart Plug Apple HomeKit",
                        ProductPrice = 49.95M,
                        Category = "Outlets",
                        Brand = new Brand{
                                BrandName = "Pure Gear"
                            },
                    },

                // Sensors
                    new Product
                    {
                        ProductName =  "FIBARO Flood Sensor (HomeKit Enabled)",
                        ProductPrice = 69.95M,
                        Category = "Sensors",
                        Brand = new Brand{
                                BrandName = "FIBARO"
                            },
                    },
                    new Product
                    {
                        ProductName =  "iHome | control iSS50 5-in-1 Smart Monitor",
                        ProductPrice = 49.95M,
                        Category = "Sensors",
                        Brand = new Brand{
                                BrandName = "iHome"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Eve Aqua Smart Water Controller",
                        ProductPrice = 99.95M,
                        Category = "Sensors",
                        Brand = new Brand{
                                BrandName = "Eve"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Eve Degree Connected Weather Station",
                        ProductPrice = 69.95M,
                        Category = "Sensors",
                        Brand = new Brand{
                                BrandName = "Eve"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Eve Room Indoor Air Quality Monitor",
                        ProductPrice = 99.95M,
                        Category = "Sensors",
                        Brand = new Brand{
                                BrandName = "Eve"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Eve Door & Window Wireless Contact Sensor",
                        ProductPrice = 39.95M,
                        Category = "Sensors",
                        Brand = new Brand{
                                BrandName = "Eve"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Eve Motion Wireless Motion Sensor",
                        ProductPrice = 49.95M,
                        Category = "Sensors",
                        Brand = new Brand{
                                BrandName = "Eve"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Eve Button - Connected Home Remote",
                        ProductPrice = 49.95M,
                        Category = "Sensors",
                        Brand = new Brand{
                                BrandName = "Eve"
                            },
                    },

                // Switches
                    new Product
                    {
                        ProductName =  "Eve Light Switch",
                        ProductPrice = 49.95M,
                        Category = "Switches",
                        Brand = new Brand{
                                BrandName = "Eve"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Leviton Decora Smart 600W Dimmer",
                        ProductPrice = 49.95M,
                        Category = "Switches",
                        Brand = new Brand{
                                BrandName = "Leviton"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Leviton Decora Smart 15 Amp Switch",
                        ProductPrice = 44.95M,
                        Category = "Switches",
                        Brand = new Brand{
                                BrandName = "Leviton"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Lutron Caséta Wireless In-Wall Light Dimmer with Remote",
                        ProductPrice = 59.95M,
                        Category = "Switches",
                        Brand = new Brand{
                                BrandName = "Lutron"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Lutron Caséta Wireless Smart Lighting Dimmer Switch Starter Kit",
                        ProductPrice = 99.95M,
                        Category = "Switches",
                        Brand = new Brand{
                                BrandName = "Lutron"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Philips Hue tap Switch",
                        ProductPrice = 49.95M,
                        Category = "Switches",
                        Brand = new Brand{
                                BrandName = "Philips"
                            },
                    },
                    new Product
                    {
                        ProductName =  "iDevices Outdoor Switch",
                        ProductPrice = 79.95M,
                        Category = "Switches",
                        Brand = new Brand{
                                BrandName = "iDevices"
                            },
                    },
                    new Product
                    {
                        ProductName =  "FIBARO Button Multicontroller",
                        ProductPrice = 59.95M,
                        Category = "Switches",
                        Brand = new Brand{
                                BrandName = "FIBARO"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Leviton Decora Smart 1000W Dimmer",
                        ProductPrice = 54.95M,
                        Category = "Switches",
                        Brand = new Brand{
                                BrandName = "Leviton"
                            },
                    },

                // Thermostats
                    new Product
                    {
                        ProductName =  "iDevices Thermostat",
                        ProductPrice = 129.95M,
                        Category = "Thermostats",
                        Brand = new Brand{
                                BrandName = "iDevices"
                            },
                    },
                    new Product
                    {
                        ProductName =  "ecobee3 lite Smart Thermostat",
                        ProductPrice = 169.95M,
                        Category = "Thermostats",
                        Brand = new Brand{
                                BrandName = "ecobee"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Honeywell T5+ Smart Thermostat",
                        ProductPrice = 149.95M,
                        Category = "Thermostats",
                        Brand = new Brand{
                                BrandName = "Honeywell"
                            },
                    },

                    // Other
                        new Product
                    {
                        ProductName =  "Rachio 3 Smart Sprinkler Controller - 16-Zone",
                        ProductPrice = 279.95M,
                        Category = "Other",
                        Brand = new Brand{
                                BrandName = "Rachio"
                            },
                    },
                    new Product
                    {
                        ProductName =  "Rachio 3 Smart Sprinkler Controller - 8-Zone Apple HomeKit",
                        ProductPrice = 229.95M,
                        Category = "Other",
                        Brand = new Brand{
                                BrandName = "Rachio"
                            },
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
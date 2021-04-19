/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_print_params.c                                  :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2020/11/04 17:37:52 by mfeijao           #+#    #+#             */
/*   Updated: 2020/11/07 17:44:11 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <unistd.h>

int		main(int argc, char **argv)
{
	int		x;
	char	*temp;

	x = 1;
	while (x < argc)
	{
		temp = argv[x];
		while (*temp)
		{
			write(1, temp, 1);
			temp++;
		}
		write(1, "\n", 1);
		x++;
	}
	return (0);
}

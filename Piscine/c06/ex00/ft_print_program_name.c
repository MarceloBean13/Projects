/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_print_program_name.c                            :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2020/11/04 12:50:02 by mfeijao           #+#    #+#             */
/*   Updated: 2020/11/04 20:01:23 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <unistd.h>

int		main(int argc, char **argv)
{
	char *temp;

	(void)argc;
	temp = argv[0];
	while (*temp)
	{
		write(1, temp, 1);
		temp++;
	}
	write(1, "\n", 1);
	return (0);
}
